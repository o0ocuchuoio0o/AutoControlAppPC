using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFB
{
    public class Test
    {
        public string _Unicode(string input)
        {
            string _output = input;
            _output = _output.Replace("â","aa");
            _output = _output.Replace("ă", "aw");
            _output = _output.Replace("á", "as");
            _output = _output.Replace("à", "af");
            _output = _output.Replace("ạ", "aj");
            _output = _output.Replace("ả", "ar");
            _output = _output.Replace("ấ", "aas");
            _output = _output.Replace("ầ", "aaf");
            _output = _output.Replace("ậ", "aaj");
            _output = _output.Replace("ẩ", "aar");
            _output = _output.Replace("ắ", "aws");
            _output = _output.Replace("ằ", "awf");
            _output = _output.Replace("ặ", "awj");
            _output = _output.Replace("ẳ", "awr");
            _output = _output.Replace("đ", "dd");
            _output = _output.Replace("ê", "ee");
            _output = _output.Replace("ẻ", "er");
            _output = _output.Replace("é", "es");
            _output = _output.Replace("è", "ef");
            _output = _output.Replace("ẹ", "ej");
            _output = _output.Replace("ể", "eer");
            _output = _output.Replace("ế", "ees");
            _output = _output.Replace("ề", "eef");
            _output = _output.Replace("ệ", "eej");
            _output = _output.Replace("í", "is");
            _output = _output.Replace("ì", "if");
            _output = _output.Replace("ị", "ij");
            _output = _output.Replace("ỉ", "ir");
            _output = _output.Replace("ô", "oo");
            _output = _output.Replace("ó", "os");
            _output = _output.Replace("ò", "of");
            _output = _output.Replace("ọ", "oj");
            _output = _output.Replace("ỏ", "or");
            _output = _output.Replace("ố", "oos");
            _output = _output.Replace("ồ", "oof");
            _output = _output.Replace("ổ", "oor");
            _output = _output.Replace("ộ", "ooj");
            return _output;
        }
    }
}
