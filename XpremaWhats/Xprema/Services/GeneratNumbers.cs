﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Xprema.Services
{

   public  class GeneratNumbers  :IXpremaService 
    {
        // {Abu Ehab}

        #region " List Of All Countries "
        string[] Countries = { 
                                 "فلسطين 972","غانا 233 ","غيانا 592","غيانا الفرنسية 594 ",
                                "اتحاد روسيا الفدرالي 7 ", "غينيا الاستوائية 0240","غينيا بيساو 245 ",
                                "اثيوبا 251","مصر 20",
                                "اروبه 297 ",
                                "اريتريا 291",
                                "اسبانيا 34 ",
                                "استراليا 61",
                                "استراليا - المناطق المدارة 672 ",
                                "استونيا 372",
                                "افغانستان 93 ",
                                "الأردن 962",
                                "الارجنتين 54 ",
                                "الاسكا1907 ",
                                "الاكوادو 593 ",
                                "الامارات العربية 971",
                                "البانيا 355 ",
                                "البحرين 973",
                                "البرازيل 55 ",
                                "البرتغال 351",
                                "البوسنة/هرسك 387 ",
                                "الجابون 241",
                                "الجزائر 213 ",
                                "الجمهورية اليمنية 968",
                                "الدنمارك 45 ",
                                "السلفادور 503",
                                "السنغال 221 ",
                                "السودان 249",
                                "السويد 46 ",
                                "الصومال 252",
                                "الصين 86 ",
                                "العراق 964",
                                "الفاتيكان 3966982 ",
                                "الفلبين 63",
                                "الكنغو 242 ",
                                "المكسيك 52",
                                "المملكة السعودية 966 ",
                                "المملكة المتحدة 44",
                                "المملكة المغربية 212 ",
                                "النرويج 47","فنلندا 0358",
                                "النمسا 43 ",
                                "النيجر 227","فيتنام 84 ",
                                "الهند 91 ", "كوريا الجنوبية 82","كوريا الشمالية 850 ","كوستاريكا 506",
                                "الولايات المتحدة 1",
                                "اليابان 81 ", "فرنسا 33 ",
                                "اليونان 30",
                                "انتيجوا وباربودا 1268 ", "فنزويلا 58 ",
                                "انجولا 244",
                                "انجويلا 1264 ",
                                "اندورا 376",
                                "اندونيسيا 62 ",
                                "اورجواي 598",
                                "اوغندا 256 ",
                                "ايران 98","لبنان 961","ليبيا 218 ","مالطا 356", "مالي 223",
                                "ايرلندا 353 ",
                                "ايسلندا 354",
                                "ايطاليا 39 ","هنجاريا 036 ","هولندا 031 ",
                                "غينيا الجديدة 675",
                                "باراجواي 595 ",
                                "باكستان 92", "فيجي 679", "هونج كونج 852",
                                "بالو 680 ",
                                "بربادوس 1246","نيجيريا 234 ",
                                "برمودا 1441 ",
                                "بروني 673",
                                "بلغاريا 359 ","كندا 1", " يوغسلافيا 381",
                                "بليجكا 32",
                                "بليز 501 ","ماليزيا 60 ",
                                "بنغلاديش 880","كوبا 53 ","مدغششقر 261 ",
                                "بنما 507 ", "موريشيوس 230 ",
                                "بنين 229",
                                "بهاما 1242 ","كولومبيا 57 ","كينيا 254 ", "موزامبيق 258",
                                "بوتان 975",
                                "بوتسوانا 267 ",
                                "بورتوريكو 1787", "ناميبيا 264", "ناورو 674 ","نيبال 977",
                                "بوركينافاسو 226 ",
                                "بورما (مينمار ) 95",
                                "بوروندي 257","قرغيزستان 996",
                                "بولندا 48","جزر فارو 298 ","جزر كايمان 1345","جزر كوك 682 ","جزر كيب فيردي 238","جزر مارشال 692 ",
                                "بوليفيا 591 ",  "كاميرون 237 ",
                                "بولينيسيا الفرنسية (تاهيتي ) 689",
                                "بيرو 51 ", "كلدونيا الجديدة 687",
                                "تايلاند 66","كمبوديا 855 ",
                                "تايوان 886 ","جزر الكريسماس 619164","جزر الكناري 34 ","جزر انتيلس (الهولندية ) 599","جزر تركس وكيكوس 1649 ","جزر سلمون 677",
                                 "تركيا 90",  "قبرص 357 ",
                                 "ترينداد وتوباجوا 1868 ", "لاتفيا 371",
                                 "تشاد 235", "لاوس 856 ",
                                 "تشيك 420 ","تشيلي 56","تنزانيا 255 ","توجو 228","توفالو 688 ","تونجا 676","تونس 216 ",
                                 "جامايكا 1876","جبل طارق 350 ","جرينادا 1473","جرينلاند 299 ","جزر العذراء الأمريكية 1340",
                                 "جزر الفوكلاند 500","جزر القمر 269 "
                                 ,"جزرماريانا 247","جزيرة اسينشن 247 ","جزيرة كوكوز 6722"," 6723   جزيرة نورفولك ","جزيرة نيوي 683","جمهورية اذربيجان 994 ","جمهورية ارمينا 374" ,
                                 "جمهورية افريقيا 236 ","جمهورية الدومينيكان 1809",
                                 "جمهورية الكنغو الديمقراطية 243 ","جمهورية اليمن 967","جمهورية اوزباكستان 998 ","جمهورية اوكرانيا 380","جمهورية بيلاروس 375" ,
                                 "توركمنيستان 993","جمهورية جورجيا 995 ","جمهورية سلوفاكيا 421","جمهورية طاجيكستان 7377","جمهورية غينيا 224"
                                 ,"جمهورية كازاخستان 7 ","جمهورية كرواتيا 385","جمهورية ليتوانيا 370 ","جمهورية مصر ","جنوب أفريقيا 27 ","جواد يلوب 595",
                                 "جوام 1671 ","جيبوتي 253","دولة قطر 974 ","دومينيكا 1767","دييجوجارسيا 46 ","رواندا 250"
                                 ,"رومانيا 40","ريونيون 262","زامبيا 260 ","زيمبابوي 263","ساحل العاج 225",
                                 "سامو (الولايات المتحدة ) 684","ساموالغربية 685 ","سان مارينو 378","ساوتامي وبرنسيبه 239 ","سلطنة عمان 968","سلوفينيا 386 "           
                                 ,"سنت بيري وميقيولون 508","سنت فينسنت 180945","سنت كيت ونينس 1869","سنت لوسيا 1758 ","سنت هيكلينا 290"
                                 ,"سنغافورة 65 ","سوازيلاند 268","سوريا 963 ",
                                 "سورينام 597","سويسرا 41","سيراليون 232"
                               


                                                  
                            };
        #endregion

        #region " This Function Populate Countries Whith It's Keys "
        public List<string> PopulateCountries()
        {
            List<string> List = new List<string>();
            List.Clear();
            foreach (string item in Countries)
            {
                List.Add(item);
            }
            return List;
        }
        #endregion

        #region" Get All Countries Keyes "
        public List<string> AllKeys()
        {

            string b = string.Empty;
            List<string> List = new List<string>();
            List.Clear();
            foreach (string item in Countries)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (Char.IsDigit(item[i]))
                    {
                        b += item[i];
                    }
                }
                List.Add(b);
                b = null;
            }
            return List;
        }
        #endregion 

        #region " Generate Phone Numbers  "
       // 
     
        public IEnumerable<string> GeneratePhoneNumbers(int Ky ,string  Nbr)
        {

           // var Kyss = from k in AllKeys() select k;
           //List<string> xNumbers = new List <string>();
           //var place = Nbr.ToCharArray();
          
           //    StringBuilder  XCount =new StringBuilder();
           //    for (int i = 0; i < place.Count(); i++)
           //    {
           //        XCount .Append ("0");
           //    }
            
           //     for (int i = 0; i < place.Length  ; ++i)
           //    {
           //         //if (!ContactStore.numberExists(Ky + i.ToString("Nbr") + "@s.whatsapp.net")) {

           //         //    ContactStore.AddContact(new Contact(0, Ky + i.ToString(XCount .ToString () ) +
           //         //                           "@s.whatsapp.net", "", "whatsAppUser" + i.ToString(), "", ""));
           //         //}

           //         xNumbers.Add(Ky + i.ToString(XCount.ToString()));
                    
           //     }
           //     return xNumbers;
         ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            string Itm = "";
            for (int i = 0; i < Nbr.Length; i++)
            {
                Itm = Itm + "0";
            }

            Commands.WhatsAppNumberCommand cmd = new Commands.WhatsAppNumberCommand();

            for (int i = 0; i < int.Parse(Nbr); ++i)

            {
                cmd.AddPhone(new XdataType.PhoneNumber(Ky.ToString(), "", i.ToString(Itm)), DateTime.Now, new XdataType.Name("WhatsAppUser", "", ""), true, "");
                Application.DoEvents();
                    //if (!ContactStore.numberExists(Ky + i.ToString("Nbr") + "@s.whatsapp.net"))
                    //{

                    //    ContactStore.AddContact(new Contact(0, Ky + i.ToString(Itm.ToString()) +
                    //                           "@s.whatsapp.net", "", "whatsAppUser" + i.ToString(), "", ""));
                    //}

                yield return Ky + i.ToString(Itm);   
            }

        }
        #endregion



        public void StartService()
        {
            throw new NotImplementedException();
        }

        public void StopService()
        {
            throw new NotImplementedException();
        }

        public bool Status
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double CurrntStep
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
