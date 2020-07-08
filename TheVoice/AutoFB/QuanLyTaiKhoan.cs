using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DocDuLieu;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using System.IO;

namespace AutoFB
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            daSqllite dl = new daSqllite();
            DataSet ds = new DataSet();
            ds = dl.loadData();
            if(ds.Tables.Count>0)
            {
                ListTaiKhoan.DataSource = ds.Tables[0];
            }
           
        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            hienthi();
            //foreach (DataGridViewRow row in ListTaiKhoan.Rows)
            //{
            //    int i = row.Index;
            //    int chk = -1;
            //    try
            //    {
            //        chk = int.Parse(ListTaiKhoan.Rows[i].Cells["IDPhone"].Value.ToString());
            //    }
            //    catch { }
            //    if (chk != -1)
            //    {
            //        ListTaiKhoan.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
            //    }

            //}
        }
        private DataTable Excel_To_DataTable(string pRutaArchivo, int pHojaIndex)
        {
          
            DataTable Tabla = null;
            try
            {
                if (System.IO.File.Exists(pRutaArchivo))
                {

                    IWorkbook workbook = null;  //IWorkbook determina si es xls o xlsx              
                    ISheet worksheet = null;
                    string first_sheet_name = "";

                    using (FileStream FS = new FileStream(pRutaArchivo, FileMode.Open, FileAccess.Read))
                    {
                        workbook = WorkbookFactory.Create(FS);          //Abre tanto XLS como XLSX
                        worksheet = workbook.GetSheetAt(pHojaIndex);    //Obtener Hoja por indice
                        first_sheet_name = worksheet.SheetName;         //Obtener el nombre de la Hoja

                        Tabla = new DataTable(first_sheet_name);
                        Tabla.Rows.Clear();
                        Tabla.Columns.Clear();

                        // Leer Fila por fila desde la primera
                        for (int rowIndex = 0; rowIndex <= worksheet.LastRowNum; rowIndex++)
                        {
                            DataRow NewReg = null;
                            IRow row = worksheet.GetRow(rowIndex);
                            IRow row2 = null;
                            IRow row3 = null;

                            if (rowIndex == 0)
                            {
                                row2 = worksheet.GetRow(rowIndex + 1); //Si es la Primera fila, obtengo tambien la segunda para saber el tipo de datos
                                row3 = worksheet.GetRow(rowIndex + 2); //Y la tercera tambien por las dudas
                            }

                            if (row != null) //null is when the row only contains empty cells 
                            {
                                if (rowIndex > 0) NewReg = Tabla.NewRow();

                                int colIndex = 0;
                                //Leer cada Columna de la fila
                                foreach (ICell cell in row.Cells)
                                {
                                    object valorCell = null;
                                    string cellType = "";
                                    string[] cellType2 = new string[2];

                                    if (rowIndex == 0) //Asumo que la primera fila contiene los titlos:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            ICell cell2 = null;
                                            if (i == 0) { cell2 = row2.GetCell(cell.ColumnIndex); }
                                            else { cell2 = row3.GetCell(cell.ColumnIndex); }

                                            if (cell2 != null)
                                            {
                                                switch (cell2.CellType)
                                                {
                                                    case CellType.Blank: break;
                                                    case CellType.Boolean: cellType2[i] = "System.Boolean"; break;
                                                    case CellType.String: cellType2[i] = "System.String"; break;
                                                    case CellType.Numeric:
                                                        if (HSSFDateUtil.IsCellDateFormatted(cell2)) { cellType2[i] = "System.DateTime"; }
                                                        else
                                                        {
                                                            cellType2[i] = "System.Double";  //valorCell = cell2.NumericCellValue;
                                                        }
                                                        break;

                                                    case CellType.Formula:
                                                        bool continuar = true;
                                                        switch (cell2.CachedFormulaResultType)
                                                        {
                                                            case CellType.Boolean: cellType2[i] = "System.Boolean"; break;
                                                            case CellType.String: cellType2[i] = "System.String"; break;
                                                            case CellType.Numeric:
                                                                if (HSSFDateUtil.IsCellDateFormatted(cell2)) { cellType2[i] = "System.DateTime"; }
                                                                else
                                                                {
                                                                    try
                                                                    {
                                                                        //DETERMINAR SI ES BOOLEANO
                                                                        if (cell2.CellFormula == "TRUE()") { cellType2[i] = "System.Boolean"; continuar = false; }
                                                                        if (continuar && cell2.CellFormula == "FALSE()") { cellType2[i] = "System.Boolean"; continuar = false; }
                                                                        if (continuar) { cellType2[i] = "System.Double"; continuar = false; }
                                                                    }
                                                                    catch { }
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    default:
                                                        cellType2[i] = "System.String"; break;
                                                }
                                            }
                                        }

                                        //Resolver las diferencias de Tipos
                                        if (cellType2[0] == cellType2[1]) { cellType = cellType2[0]; }
                                        else
                                        {
                                            if (cellType2[0] == null) cellType = cellType2[1];
                                            if (cellType2[1] == null) cellType = cellType2[0];
                                            if (cellType == "") cellType = "System.String";
                                        }

                                        //Obtener el nombre de la Columna
                                        string colName = "Column_{0}";
                                        try { colName = cell.StringCellValue; }
                                        catch { colName = string.Format(colName, colIndex); }

                                        //Verificar que NO se repita el Nombre de la Columna
                                        foreach (DataColumn col in Tabla.Columns)
                                        {
                                            if (col.ColumnName == colName) colName = string.Format("{0}_{1}", colName, colIndex);
                                        }

                                        //Agregar el campos de la tabla:
                                        DataColumn codigo = new DataColumn(colName, System.Type.GetType(cellType));
                                        Tabla.Columns.Add(codigo); colIndex++;
                                    }
                                    else
                                    {
                                        //Las demas filas son registros:
                                        switch (cell.CellType)
                                        {
                                            case CellType.Blank: valorCell = DBNull.Value; break;
                                            case CellType.Boolean: valorCell = cell.BooleanCellValue; break;
                                            case CellType.String: valorCell = cell.StringCellValue; break;
                                            case CellType.Numeric:
                                                if (HSSFDateUtil.IsCellDateFormatted(cell)) { valorCell = cell.DateCellValue; }
                                                else { valorCell = cell.NumericCellValue; }
                                                break;
                                            case CellType.Formula:
                                                switch (cell.CachedFormulaResultType)
                                                {
                                                    case CellType.Blank: valorCell = DBNull.Value; break;
                                                    case CellType.String: valorCell = cell.StringCellValue; break;
                                                    case CellType.Boolean: valorCell = cell.BooleanCellValue; break;
                                                    case CellType.Numeric:
                                                        if (HSSFDateUtil.IsCellDateFormatted(cell)) { valorCell = cell.DateCellValue; }
                                                        else { valorCell = cell.NumericCellValue; }
                                                        break;
                                                }
                                                break;
                                            default: valorCell = cell.StringCellValue; break;
                                        }
                                        //Agregar el nuevo Registro
                                        if (cell.ColumnIndex <= Tabla.Columns.Count - 1) NewReg[cell.ColumnIndex] = valorCell;
                                    }
                                }
                            }
                            if (rowIndex > 0) Tabla.Rows.Add(NewReg);
                        }
                        Tabla.AcceptChanges();
                    }
                }
                else
                {
                    throw new Exception("ERROR 404: El archivo especificado NO existe.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Tabla;
        }
        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "Excel 2003|*.xls|Excel 2007|*.xlsx|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DuLieuExcel dExcel = new DuLieuExcel();
                DataTable DuLieu = new DataTable();               

                DuLieu = Excel_To_DataTable(dlg.FileName,0);
                if (DuLieu.Rows.Count > 0)
                {
                    foreach(DataRow r in DuLieu.Rows)
                    {
                        #region // truyền biến
                        string UID = r["UID"].ToString();
                        string USERNAME = r["USERNAME"].ToString();
                        string PASSWORD = r["PASSWORD"].ToString();
                        string SECRET = r["SECRET"].ToString();
                        string COOKIES = r["COOKIES"].ToString();
                        int DAY = 0;
                        try
                        {
                            DAY=int.Parse(r["DAY"].ToString());
                        }
                        catch { }
                        int MONTH = 0;
                        try
                        {
                            MONTH = int.Parse(r["MONTH"].ToString());
                        }
                        catch { }
                        int YEAR = 0;
                        try
                        {
                            YEAR = int.Parse(r["YEAR"].ToString());
                        }
                        catch { }
                        string FULLNAME = r["FULLNAME"].ToString();
                        string GENDER = r["GENDER"].ToString();
                        string AVATAR = r["AVATAR"].ToString();
                        string COVER = r["COVER"].ToString();
                        string HOME = r["HOME"].ToString();
                        string CITY = r["CITY"].ToString();
                        string BIO = r["BIO"].ToString();
                        string WORK = r["WORK"].ToString();
                        string UNIVERSITY = r["UNIVERSITY"].ToString();
                        string SCHOOL = r["SCHOOL"].ToString();
                        string FRIENDS = r["FRIENDS"].ToString();
                        string ISP = r["ISP"].ToString();
                        string TIME_REGISTER = r["TIME_REGISTER"].ToString();
                        string GMAIL_USERNAME = r["GMAIL_USERNAME"].ToString();
                        string GMAIL_PASSWORD = r["GMAIL_PASSWORD"].ToString();
                        string GMAIL_RECOVERY = r["GMAIL_RECOVERY"].ToString(); 
                        string GMAIL_TIME_REGISTER = r["GMAIL_TIME_REGISTER"].ToString();
                        int IDPhone = -1;
                        #endregion


                        daSqllite kt = new daSqllite();
                        DataSet ttkt = new DataSet();
                        ttkt = kt.KiemTraMail(USERNAME);
                        if(ttkt.Tables[0].Rows.Count>0)
                        {

                        }
                        else
                        {
                            #region // thêm vào csdl
                            daSqllite them = new daSqllite();
                            them.Insert(UID, USERNAME, PASSWORD, SECRET, COOKIES, DAY,
                            MONTH, YEAR, FULLNAME, GENDER, AVATAR, COVER,
                            HOME, CITY, BIO, WORK, UNIVERSITY, SCHOOL, FRIENDS,
                            ISP, TIME_REGISTER, GMAIL_USERNAME,
                            GMAIL_PASSWORD, GMAIL_RECOVERY, GMAIL_TIME_REGISTER, IDPhone);
                            #endregion
                        }
                    }
                    #region // sau khi xong load lại dữ liệu
                    hienthi();
                    #endregion
                }
            }
        }
    }
}
