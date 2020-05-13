using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace AutoTheVoice
{
    public class cl_ReadVoice
    {
        public cl_ReadVoice()
        {
            PageFactory.InitElements(PropretiesCollection.driver, this);
        }


        #region // readspeak 2
       
        [FindsBy(How = How.XPath, Using = "//*[@class='infoBox']/ul/li[1]")]
        public IWebElement m_demo;

        [FindsBy(How = How.XPath, Using = "//*[@id='ui_wrap']/div[1]/div[1]/a[1]/img[1]")]
        public IWebElement m_demo2;


        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/div[1]/a[1]")]
        public IWebElement m_btnngonngu;

        #region // lua chon ngon ngu
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[1]/a[1]")]
        public IWebElement m_ngonnguenglish;

        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[2]/a[1]")]
        public IWebElement m_ngonngukorean;       
        #region // mc voice korean
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li/span/a")]
            public IWebElement m_mcYumi;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[2]/span/a")]
            public IWebElement m_mcHyeryun;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[3]/span/a")]
            public IWebElement m_mcHyuna;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[4]/span/a")]
            public IWebElement m_mcJimin;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[5]/span/a")]
            public IWebElement m_mcDayoung;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[6]/span/a")]
            public IWebElement m_mcGyuri;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[7]/span/a")]
            public IWebElement m_mcChorong;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[8]/span/a")]
            public IWebElement m_mcSena;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[9]/span/a")]
            public IWebElement m_mcYura;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[10]/span/a")]
            public IWebElement m_mcJihun;
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[11]/span/a")]
            public IWebElement m_mcJunwoo;        
            [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[12]/span/a")]
            public IWebElement m_mcMaru;


        #endregion
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[3]/a[1]")]
        public IWebElement m_ngonnguchinese;      
        #region // mc voice chinese
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li/span/a")]
        public IWebElement m_mcHui;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[2]/span/a")]
        public IWebElement m_mcHong;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[3]/span/a")]
        public IWebElement m_mcLiang;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[4]/span/a")]
        public IWebElement m_mcQiang;


        #endregion
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[4]/a[1]")]
        public IWebElement m_ngonngujapan;      
        #region // mc voice japan
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li/span/a")]
        public IWebElement m_mcMisaki;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[2]/span/a")]
        public IWebElement m_mcHaruka;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[3]/span/a")]
        public IWebElement m_mcSayaka;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[4]/span/a")]
        public IWebElement m_mcHikari;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[5]/span/a")]
        public IWebElement m_mcRisa;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[6]/span/a")]
        public IWebElement m_mcShow;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[7]/span/a")]
        public IWebElement m_mcRyo;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[8]/span/a")]
        public IWebElement m_mcTakeru;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[9]/span/a")]
        public IWebElement m_mcAkira;


        #endregion
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[5]/a[1]")]
        public IWebElement m_ngonnguMexicanSpanish;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[6]/a[1]")]
        public IWebElement m_ngonnguUKEnglish;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[7]/a[1]")]
        public IWebElement m_ngonnguCanadianFrench;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[8]/a[1]")]
        public IWebElement m_ngonnguChineseTaiwan;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[9]/a[1]")]
        public IWebElement m_ngonnguCantoneseChinese;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[10]/a[1]")]
        public IWebElement m_ngonnguThai;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[11]/a[1]")]
        public IWebElement m_ngonnguBrazilian;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[12]/a[1]")]
        public IWebElement m_ngonnguGerman;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[13]/a[1]")]
        public IWebElement m_ngonnguEuropeanSpanish;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[14]/a[1]")]
        #region // mc voice Spanish
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li/span/a")]
        public IWebElement m_mcLola;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[2]/span/a")]
        public IWebElement m_mcManuel;
              

        #endregion

        public IWebElement m_ngonnguItalian;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[15]/a[1]")]
        public IWebElement m_ngonnguEuropeanFrench;
        #region // mc voice EuropeanFrench
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li/span/a")]
        public IWebElement m_mcJolie;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/form/div/div[2]/div/dl[2]/dd/ul/li[2]/span/a")]
        public IWebElement m_mcLouis;   

        #endregion
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[16]/a[1]")]
        public IWebElement m_ngonnguEuropeanPortuguese;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[17]/a[1]")]
        public IWebElement m_ngonnguSwedish;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[18]/a[1]")]
        public IWebElement m_ngonnguDutch;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[19]/a[1]")]
        public IWebElement m_ngonnguAustralianEnglish;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[1]/dd[1]/div[1]/ul[1]/li[20]/a[1]")]
        public IWebElement m_ngonnguRussian;

        #endregion

       
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[3]/dd[1]/div[1]/div[1]/a[1]")]
        public IWebElement m_btnsize;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[3]/dd[1]/div[1]/ul[1]/li[2]/a[1]")]
        public IWebElement m_selectsize;
        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[1]/dl[3]/dd[1]/div[1]/ul[1]/li[1]/a[1]")]
        public IWebElement m_selectsize0;


        [FindsBy(How = How.Id, Using = "content")]
        public IWebElement m_text2;      

        [FindsBy(How = How.XPath, Using = "//*[@id='nekr_pop_content1']/form[1]/div[1]/div[2]/div[2]/dl[1]/dd[2]/a[1]/img[1]")]
        public IWebElement btnlisten;
        [FindsBy(How = How.XPath, Using = "//audio")]
        public IWebElement link2;
        public void selectV2(string ngonngu,string mcvoice)
        {
            m_demo.Click();
            Thread.Sleep(1000);
            m_btnngonngu.Click();
            Thread.Sleep(1000);
            if (ngonngu == "English")
            {
                m_ngonnguenglish.Click();
            }
            else if (ngonngu == "Korean")
            {
                m_ngonngukorean.Click();
                #region // click mc voice
                if(mcvoice=="Dayoung")
                {
                    m_mcDayoung.Click();
                }
                if (mcvoice == "Dayoung")
                {
                    m_mcDayoung.Click();
                }
                if (mcvoice == "Hyeryun")
                {
                    m_mcHyeryun.Click();
                }
                if (mcvoice == "Hyuna")
                {
                    m_mcHyuna.Click();
                }
                if (mcvoice == "Jihun")
                {
                    m_mcJihun.Click();
                }
                if (mcvoice == "Jimin")
                {
                    m_mcJimin.Click();
                }
                if (mcvoice == "Junwoo")
                {
                    m_mcJunwoo.Click();
                }
                if (mcvoice == "Sena")
                {
                    m_mcSena.Click();
                }
                if (mcvoice == "Yumi")
                {
                    m_mcYumi.Click();
                }
                if (mcvoice == "Yura")
                {
                    m_mcYura.Click();
                }
                #endregion 
            }
            else if (ngonngu == "Chinese")
            {
                m_ngonnguchinese.Click();
                #region // click mc voice
                if (mcvoice == "Hui (Mandarin)")
                {
                    m_mcHui.Click();
                }
                if (mcvoice == "Linlin (Mandarin)")
                {
                    m_mcHong.Click();
                }
                if (mcvoice == "Yafang (Taiwanese)")
                {
                    m_mcQiang.Click();
                }
                if (mcvoice == "Liang (Mandarin)")
                {
                    m_mcLiang.Click();
                }               
                #endregion 
            }
            else if (ngonngu == "Japanese")
            {
                m_ngonngujapan.Click();
                #region // click mc voice
                if(mcvoice== "Haruka")
                {
                    m_mcHaruka.Click();
                }
               
                if (mcvoice == "Hikari")
                {
                    m_mcHikari.Click();
                }
                if (mcvoice == "Misaki")
                {
                    m_mcMisaki.Click();
                }
                if (mcvoice == "Ryo")
                {
                    m_mcRyo.Click();
                }
                if (mcvoice == "Sayaka")
                {
                    m_mcSayaka.Click();
                }
                if (mcvoice == "Show")
                {
                    m_mcShow.Click();
                }
                if (mcvoice == "Takeru")
                {
                    m_mcTakeru.Click();
                }
                #endregion

            }
            else if (ngonngu == "German")
            {
                m_ngonnguGerman.Click();
            }
            else if (ngonngu == "Spanish")
            {
                m_ngonnguEuropeanSpanish.Click();
                #region // click mc voice
                if(mcvoice== "Soledad (American)")
                {
                    m_mcManuel.Click();
                }
                if (mcvoice == "Lola (Castilian)")
                {
                    m_mcLola.Click();
                }
                #endregion
            }
            else if (ngonngu == "Thai")
            {
                m_ngonnguThai.Click();
            }
            else if (ngonngu == "Russian")
            {
                m_ngonnguRussian.Click();
            }
            else if (ngonngu == "French")
            {
                m_ngonnguEuropeanFrench.Click();
                #region // click mc voice
                if (mcvoice == "Jolie")
                {
                    m_mcJolie.Click();
                }
                if (mcvoice == "Olivier")
                {
                    m_mcLouis.Click();
                }
                #endregion
            }
            else if (ngonngu == "Italian")
            {
                m_ngonnguItalian.Click();
            }
            try
            {
                Thread.Sleep(500);
                m_btnsize.Click();
                Thread.Sleep(1000);
                m_selectsize.Click();
            }
            catch { }
        }

        public void checklager()
        {
            try
            {
                Thread.Sleep(500);
                m_btnsize.Click();
                Thread.Sleep(1000);
                m_selectsize0.Click();
            }
            catch { }
        }
        public string getURLMp3_V2(string _urlvoicecu, string text)
        {
            string ex = _urlvoicecu;
            try
            {               

                m_text2.Clear();
                m_text2.SendKeys(text);
                btnlisten.Click();
                Thread.Sleep(2000);
                int kiemtra = 0;
                switch (kiemtra)
                {
                    case 0:             // label case 1
                        System.Threading.Thread.Sleep(2000);
                        goto case 1;
                        break;
                    case 1:
                        try
                        {
                            ex = SeleniumGetMeThor.GetTextLink(link2);
                            if (ex != _urlvoicecu)
                            {
                                return ex;
                            }
                            else
                            {
                                goto case 0;
                            }
                        }
                        catch { goto case 0; }
                        break;

                }

                return ex;
            }
            catch
            {
                    
            }
           return ex;
        }
        public void selectV2_TiengHan(string ngonngu, string mcvoice)
        {
            m_demo.Click();
            Thread.Sleep(1000);
            m_btnngonngu.Click();
            Thread.Sleep(1000);
            if (ngonngu == "English")
            {
                m_ngonngukorean.Click();
            }
            else if (ngonngu == "Korean")
            {
               
                m_ngonnguenglish.Click();
                #region // click mc voice
                if (mcvoice == "Dayoung")
                {
                    m_mcDayoung.Click();
                }
                if (mcvoice == "Dayoung")
                {
                    m_mcDayoung.Click();
                }
                if (mcvoice == "Hyeryun")
                {
                    m_mcHyeryun.Click();
                }
                if (mcvoice == "Hyuna")
                {
                    m_mcHyuna.Click();
                }
                if (mcvoice == "Jihun")
                {
                    m_mcJihun.Click();
                }
                if (mcvoice == "Jimin")
                {
                    m_mcJimin.Click();
                }
                if (mcvoice == "Junwoo")
                {
                    m_mcJunwoo.Click();
                }
                if (mcvoice == "Sena")
                {
                    m_mcSena.Click();
                }
                if (mcvoice == "Yumi")
                {
                    m_mcYumi.Click();
                }
                if (mcvoice == "Yura")
                {
                    m_mcYura.Click();
                }
                #endregion 
            }
            else if (ngonngu == "Chinese")
            {
                m_ngonnguchinese.Click();
                #region // click mc voice
                if (mcvoice == "Hui (Mandarin)")
                {
                    m_mcHui.Click();
                }
                if (mcvoice == "Linlin (Mandarin)")
                {
                    m_mcHong.Click();
                }
                if (mcvoice == "Yafang (Taiwanese)")
                {
                    m_mcQiang.Click();
                }
                if (mcvoice == "Liang (Mandarin)")
                {
                    m_mcLiang.Click();
                }
                #endregion
            }
            else if (ngonngu == "Japanese")
            {
                m_ngonngujapan.Click();
                #region // click mc voice
                if (mcvoice == "Haruka")
                {
                    m_mcHaruka.Click();
                }

                if (mcvoice == "Hikari")
                {
                    m_mcHikari.Click();
                }
                if (mcvoice == "Misaki")
                {
                    m_mcMisaki.Click();
                }
                if (mcvoice == "Ryo")
                {
                    m_mcRyo.Click();
                }
                if (mcvoice == "Sayaka")
                {
                    m_mcSayaka.Click();
                }
                if (mcvoice == "Show")
                {
                    m_mcShow.Click();
                }
                if (mcvoice == "Takeru")
                {
                    m_mcTakeru.Click();
                }
                #endregion

            }
            else if (ngonngu == "German")
            {
                m_ngonnguGerman.Click();
            }
            else if (ngonngu == "Spanish")
            {
                m_ngonnguEuropeanSpanish.Click();
                #region // click mc voice
                if (mcvoice == "Soledad (American)")
                {
                    m_mcManuel.Click();
                }
                if (mcvoice == "Lola (Castilian)")
                {
                    m_mcLola.Click();
                }
                #endregion
            }
            else if (ngonngu == "Thai")
            {
                m_ngonnguThai.Click();
            }
            else if (ngonngu == "Russian")
            {
                m_ngonnguRussian.Click();
            }
            else if (ngonngu == "French")
            {
                m_ngonnguEuropeanFrench.Click();
            }
            else if (ngonngu == "Italian")
            {
                m_ngonnguItalian.Click();
            }
            try
            {
                Thread.Sleep(500);
                m_btnsize.Click();
                Thread.Sleep(1000);
                m_selectsize.Click();
            }
            catch { }
        }
        #endregion

       

        #region // lấy voice ở trang https://tts.cool/

        #region // lựa chọn service lấy
        
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[3]/a")]
        public IWebElement m_Polly;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[4]/a")]
        public IWebElement m_CereProc;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[5]/a")]
        public IWebElement m_IBMWatson;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[6]/a")]
        public IWebElement m_Acapela;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[7]/a")]
        public IWebElement m_Oddcast;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[8]/a")]
        public IWebElement m_ReadSpeaker;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[9]/a")]
        public IWebElement m_GoogleTranslate;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[1]/ul/li[6]/a")]
        public IWebElement m_iSpeech;
        public void select_Service(string ten)
        {
            
            if (ten == "Polly")
            {
                m_Polly.Click();
            }
            else if (ten == "CereProc")
            {
                m_CereProc.Click();
            }
            if (ten == "IBMWatson")
            {
                m_IBMWatson.Click();
            }
            if (ten == "Acapela")
            {
                m_Acapela.Click();
            }
            if (ten == "Oddcast")
            {
                m_Oddcast.Click();
            }
            if (ten == "ReadSpeaker")
            {
                m_ReadSpeaker.Click();
            }
            if (ten == "GoogleTranslate")
            {
                m_GoogleTranslate.Click();
            }
            if (ten == "iSpeech")
            {
                m_iSpeech.Click();
            }
            Thread.Sleep(2000);
        }

        #endregion
        #region // lựa chọn giới tính
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[2]/ul/li[3]/a")]
        public IWebElement m_Male;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[2]/ul/li[4]/a")]
        public IWebElement m_Female;
        public void select_Sex(string sex)
        {
            

            if (sex == "Male")
            {
                m_Male.Click();
            }
            else if (sex == "Female")
            {
                m_Female.Click();
            }           
            Thread.Sleep(2000);
        }

        #endregion
        #region // lựa chọn ngôn ngữ
        [FindsBy(How = How.Id, Using = "toggleLangs")]
        public IWebElement m_showngonngu;

        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[12]")]
        public IWebElement m_englist_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[35]")]
        public IWebElement m_Korean_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[7]")]
        public IWebElement m_Chinese_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[32]")]
        public IWebElement m_Japanese_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[24]")]
        public IWebElement m_German_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[48]")]
        public IWebElement m_Spanish_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[53]")]
        public IWebElement m_Thai_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[45]")]
        public IWebElement m_Russian_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[20]")]
        public IWebElement m_French_tts;
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div[2]/div[3]/button[31]")]
        public IWebElement m_Italian_tts;
        #region // chọn voice
        [FindsBy(How = How.XPath, Using = "//button[@class='button button-voice is-light is-rounded']")]
        public IWebElement btnvoice;
        #endregion
        public void selectV2_TTSCool(string ngonngu)
        {
            m_showngonngu.Click();
            Thread.Sleep(2000);          
            if (ngonngu == "English")
            {
                m_englist_tts.Click();
            }
            else if (ngonngu == "Korean")
            {
                m_Korean_tts.Click();               
            }
            else if (ngonngu == "Chinese")
            {
                m_Chinese_tts.Click();              
            }
            else if (ngonngu == "Japanese")
            {
                m_Japanese_tts.Click();           
            }
            else if (ngonngu == "German")
            {
                m_German_tts.Click();
            }
            else if (ngonngu == "Spanish")
            {
                m_Spanish_tts.Click();               
            }
            else if (ngonngu == "Thai")
            {
                m_Thai_tts.Click();
            }
            else if (ngonngu == "Russian")
            {
                m_Russian_tts.Click();
            }
            else if (ngonngu == "French")
            {
                m_French_tts.Click();
            }
            else if (ngonngu == "Italian")
            {
                m_Italian_tts.Click();
            }
            Thread.Sleep(1000);
            btnvoice.Click();
        }

        #endregion

      
        [FindsBy(How = How.Id, Using = "text")]
        public IWebElement txt_ttscool;
        [FindsBy(How = How.Id, Using = "playbutton")]
        public IWebElement btnSayIt;
        [FindsBy(How = How.XPath, Using = "//audio")]
        public IWebElement link_ttscool;

        public string getURL_TTSCool(string _urlvoicecu, string text)
        {
            string ex = _urlvoicecu;
            try
            {

                txt_ttscool.Clear();
                txt_ttscool.SendKeys(text);
                btnSayIt.Click();
                Thread.Sleep(3000);
                int kiemtra = 0;
                switch (kiemtra)
                {
                    case 0:             // label case 1
                        System.Threading.Thread.Sleep(3000);
                        goto case 1;
                        break;
                    case 1:
                        try
                        {
                            ex = SeleniumGetMeThor.GetTextLink(link_ttscool);
                            Thread.Sleep(4000);
                            if (ex != _urlvoicecu)
                            {
                                return ex;
                            }
                            else
                            {
                                goto case 0;
                            }
                        }
                        catch { goto case 0; }
                        break;

                }

                return ex;
            }
            catch
            {

            }
            return ex;
        }

        #endregion




    }

}
