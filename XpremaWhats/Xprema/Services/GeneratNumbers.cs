using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Xprema.Services
{
    class GeneratNumbers
    {

        string[] Countries = {
		"AF:Afghanistan (‫افغانستان‬‎):93",
		"AX:Åland Islands (Åland):358",
		"AL:Albania (Shqipëria):355",
		"DZ:Algeria (‫الجزائر‬‎):213",
		"AS:American Samoa:1",
		"AD:Andorra:376",
		"AO:Angola:244",
		"AI:Anguilla:1",
		"AG:Antigua and Barbuda:1",
		"AR:Argentina:54",
		"AM:Armenia (Հայաստան):374",
		"AW:Aruba:297",
		"AC:Ascension Island:247",
		"AU:Australia:61",
		"AT:Austria (Österreich):43",
		"AZ:Azerbaijan (Azərbaycan):994",
		"BS:Bahamas:1",
		"BH:Bahrain (‫البحرين‬‎):973",
		"BD:Bangladesh (বাংলাদেশ):880",
		"BB:Barbados:1",
		"BY:Belarus (Беларусь):375",
		"BE:Belgium (België):32",
		"BZ:Belize:501",
		"BJ:Benin (Bénin):229",
		"BM:Bermuda:1",
		"BT:Bhutan (འབྲུག):975",
		"BO:Bolivia:591",
		"BA:Bosnia and Herzegovina (Босна и Херцеговина):387",
		"BW:Botswana:267",
		"BR:Brazil (Brasil):55",
		"IO:British Indian Ocean Territory:246",
		"VG:British Virgin Islands:1",
		"BN:Brunei:673",
		"BG:Bulgaria (България):359",
		"BF:Burkina Faso:226",
		"BI:Burundi (Uburundi):257",
		"KH:Cambodia (កម្ពុជា):855",
		"CM:Cameroon (Cameroun):237",
		"CA:Canada:1",
		"CV:Cape Verde (Kabu Verdi):238",
		"BQ:Caribbean Netherlands:599",
		"KY:Cayman Islands:1",
		"CF:Central African Republic (République centrafricaine):236",
		"TD:Chad (Tchad):235",
		"CL:Chile:56",
		"CN:China (中国):86",
		"CX:Christmas Island:61",
		"CC:Cocos [Keeling] Islands:61",
		"CO:Colombia:57",
		"KM:Comoros (‫جزر القمر‬‎):269",
		"CD:Congo [DRC] (Jamhuri ya Kidemokrasia ya Kongo):243",
		"CG:Congo [Republic] (Congo-Brazzaville):242",
		"CK:Cook Islands:682",
		"CR:Costa Rica:506",
		"CI:Côte d’Ivoire:225",
		"HR:Croatia (Hrvatska):385",
		"CU:Cuba:53",
		"CW:Curaçao:599",
		"CY:Cyprus (Κύπρος):357",
		"CZ:Czech Republic (Česká republika):420",
		"DK:Denmark (Danmark):45",
		"DJ:Djibouti:253",
		"DM:Dominica:1",
		"DO:Dominican Republic (República Dominicana):1",
		"EC:Ecuador:593",
		"EG:Egypt (‫مصر‬‎):20",
		"SV:El Salvador:503",
		"GQ:Equatorial Guinea (Guinea Ecuatorial):240",
		"ER:Eritrea:291",
		"EE:Estonia (Eesti):372",
		"ET:Ethiopia:251",
		"FK:Falkland Islands [Islas Malvinas]:500",
		"FO:Faroe Islands (Føroyar):298",
		"FJ:Fiji:679",
		"FI:Finland (Suomi):358",
		"FR:France:33",
		"GF:French Guiana (Guyane française):594",
		"PF:French Polynesia (Polynésie française):689",
		"GA:Gabon:241",
		"GM:Gambia:220",
		"GE:Georgia (საქართველო):995",
		"DE:Germany (Deutschland):49",
		"GH:Ghana (Gaana):233",
		"GI:Gibraltar:350",
		"GR:Greece (Ελλάδα):30",
		"GL:Greenland (Kalaallit Nunaat):299",
		"GD:Grenada:1",
		"GP:Guadeloupe:590",
		"GU:Guam:1",
		"GT:Guatemala:502",
		"GG:Guernsey:44",
		"GN:Guinea (Guinée):224",
		"GW:Guinea-Bissau (Guiné Bissau):245",
		"GY:Guyana:592",
		"HT:Haiti:509",
		"HN:Honduras:504",
		"HK:Hong Kong (香港):852",
		"HU:Hungary (Magyarország):36",
		"IS:Iceland (Ísland):354",
		"IN:India (भारत):91",
		"ID:Indonesia:62",
		"IR:Iran (‫ایران‬‎):98",
		"IQ:Iraq (‫العراق‬‎):964",
		"IE:Ireland:353",
		"IM:Isle of Man:44",
		"IL:Israel (‫ישראל‬‎):972",
		"IT:Italy (Italia):39",
		"JM:Jamaica:1",
		"JP:Japan (日本):81",
		"JE:Jersey:44",
		"JO:Jordan (‫الأردن‬‎):962",
		"KZ:Kazakhstan (Казахстан):7",
		"KE:Kenya:254",
		"KI:Kiribati:686",
		"KW:Kuwait (‫الكويت‬‎):965",
		"KG:Kyrgyzstan:996",
		"LA:Laos (ສ.ປ.ປ ລາວ):856",
		"LV:Latvia (Latvija):371",
		"LB:Lebanon (‫لبنان‬‎):961",
		"LS:Lesotho:266",
		"LR:Liberia:231",
		"LY:Libya (‫ليبيا‬‎):218",
		"LI:Liechtenstein:423",
		"LT:Lithuania (Lietuva):370",
		"LU:Luxembourg:352",
		"MO:Macau (澳門):853",
		"MK:Macedonia [FYROM] (Македонија):389",
		"MG:Madagascar (Madagasikara):261",
		"MW:Malawi:265",
		"MY:Malaysia:60",
		"MV:Maldives:960",
		"ML:Mali:223",
		"MT:Malta:356",
		"MH:Marshall Islands:692",
		"MQ:Martinique:596",
		"MR:Mauritania (‫موريتانيا‬‎):222",
		"MU:Mauritius (Moris):230",
		"YT:Mayotte:262",
		"MX:Mexico (México):52",
		"FM:Micronesia:691",
		"MD:Moldova (Republica Moldova):373",
		"MC:Monaco:377",
		"MN:Mongolia (Монгол):976",
		"ME:Montenegro (Crna Gora):382",
		"MS:Montserrat:1",
		"MA:Morocco (‫المغرب‬‎):212",
		"MZ:Mozambique (Moçambique):258",
		"MM:Myanmar [Burma] (မြန်မာ):95",
		"NA:Namibia:264",
		"NR:Nauru:674",
		"NP:Nepal (नेपाल):977",
		"NL:Netherlands (Nederland):31",
		"NC:New Caledonia (Nouvelle-Calédonie):687",
		"NZ:New Zealand:64",
		"NI:Nicaragua:505",
		"NE:Niger (Nijar):227",
		"NG:Nigeria:234",
		"NU:Niue:683",
		"NF:Norfolk Island:672",
		"MP:Northern Mariana Islands:1",
		"KP:North Korea (조선 민주주의 인민 공화국):850",
		"NO:Norway (Norge):47",
		"OM:Oman (‫عُمان‬‎):968",
		"PK:Pakistan (‫پاکستان‬‎):92",
		"PW:Palau:680",
		"PS:Palestine (‫فلسطين‬‎):970",
		"PA:Panama (Panamá):507",
		"PG:Papua New Guinea:675",
		"PY:Paraguay:595",
		"PE:Peru (Perú):51",
		"PH:Philippines:63",
		"PL:Poland (Polska):48",
		"PT:Portugal:351",
		"PR:Puerto Rico:1",
		"QA:Qatar (‫قطر‬‎):974",
		"RE:Réunion:262",
		"RO:Romania (România):40",
		"RU:Russia (Россия):7",
		"RW:Rwanda:250",
		"BL:Saint Barthélemy (Saint-Barthélémy):590",
		"SH:Saint Helena:290",
		"KN:Saint Kitts and Nevis:1",
		"LC:Saint Lucia:1",
		"MF:Saint Martin (Saint-Martin [partie française]):590",
		"PM:Saint Pierre and Miquelon (Saint-Pierre-et-Miquelon):508",
		"VC:Saint Vincent and the Grenadines:1",
		"WS:Samoa:685",
		"SM:San Marino:378",
		"ST:São Tomé and Príncipe (São Tomé e Príncipe):239",
		"SA:Saudi Arabia (‫المملكة العربية السعودية‬‎):966",
		"SN:Senegal (Sénégal):221",
		"RS:Serbia (Србија):381",
		"SC:Seychelles:248",
		"SL:Sierra Leone:232",
		"SG:Singapore:65",
		"SX:Sint Maarten:1",
		"SK:Slovakia (Slovensko):421",
		"SI:Slovenia (Slovenija):386",
		"SB:Solomon Islands:677",
		"SO:Somalia (Soomaaliya):252",
		"ZA:South Africa:27",
		"KR:South Korea (대한민국):82",
		"SS:South Sudan (‫جنوب السودان‬‎):211",
		"ES:Spain (España):34",
		"LK:Sri Lanka (ශ්‍රී ලංකාව):94",
		"SD:Sudan (‫السودان‬‎):249",
		"SR:Suriname:597",
		"SJ:Svalbard and Jan Mayen (Svalbard og Jan Mayen):47",
		"SZ:Swaziland:268",
		"SE:Sweden (Sverige):46",
		"CH:Switzerland (Schweiz):41",
		"SY:Syria (‫سوريا‬‎):963",
		"TW:Taiwan (台灣):886",
		"TJ:Tajikistan:992",
		"TZ:Tanzania:255",
		"TH:Thailand (ไทย):66",
		"TL:Timor-Leste:670",
		"TG:Togo:228",
		"TK:Tokelau:690",
		"TO:Tonga:676",
		"TT:Trinidad and Tobago:1",
		"TA:Tristan da Cunha:290",
		"TN:Tunisia (‫تونس‬‎):216",
		"TR:Turkey (Türkiye):90",
		"TM:Turkmenistan:993",
		"TC:Turks and Caicos Islands:1",
		"TV:Tuvalu:688",
		"VI:U.S. Virgin Islands:1",
		"UG:Uganda:256",
		"UA:Ukraine (Україна):380",
		"AE:United Arab Emirates (‫الإمارات العربية المتحدة‬‎):971",
		"GB:United Kingdom:44",
		"US:United States:1",
		"UY:Uruguay:598",
		"UZ:Uzbekistan (Ўзбекистон):998",
		"VU:Vanuatu:678",
		"VA:Vatican City (Città del Vaticano):379",
		"VE:Venezuela:58",
		"VN:Vietnam (Việt Nam):84",
		"WF:Wallis and Futuna:681",
		"EH:Western Sahara (‫الصحراء الغربية‬‎):212",
		"YE:Yemen (‫اليمن‬‎):967",
		"ZM:Zambia:260",
		"ZW:Zimbabwe:263"

	};
        //=
        // This Function Populate Countries Whith It's Keys
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

       public  IEnumerable<string> CreateCounter()

        {
            // Generate Numbers :  000000000, 000000001, ..., 999999999
            for (int i = 0; i < 1000000000; ++i)
            {
                yield return i.ToString("000000000");
            }

            foreach (var item in AllKeys() )
            {
                for (int i = 0; i < 100000000; ++i)
                {
                    yield return item + i.ToString("00000000");
                }
            }
        
          
        }


    }
}
