using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHPCountries{

    public class CountriesDAO{

        private CountryList _cunts = null;

        public CountryList Countries {
            get { return _cunts; }
            set { _cunts = value; }
        }

        public static string GetLocationCountry(int n) {
            string outy = "";
            switch(n) {

                case 0:
                    outy = "None";
                    break;
                case 4:
                    outy = "Afghanistan";
                    break;
                case 248:
                    outy = "Aland Islands";
                    break;
                case 8:
                    outy = "Albania";
                    break;
                case 12:
                    outy = "Algeria";
                    break;
                case 16:
                    outy = "American Samoa";
                    break;
                case 20:
                    outy = "Andorra";
                    break;
                case 24:
                    outy = "Angola";
                    break;
                case 660:
                    outy = "Anguilla";
                    break;
                case 10:
                    outy = "Antarctica";
                    break;
                case 28:
                    outy = "Antigua and Barbuda";
                    break;
                case 32:
                    outy = "Argentina";
                    break;
                case 51:
                    outy = "Armenia";
                    break;
                case 533:
                    outy = "Aruba";
                    break;
                case 36:
                    outy = "Australia";
                    break;
                case 40:
                    outy = "Austria";
                    break;
                case 31:
                    outy = "Azerbaijan";
                    break;
                case 44:
                    outy = "Bahamas";
                    break;
                case 48:
                    outy = "Bahrain";
                    break;
                case 50:
                    outy = "Bangladesh";
                    break;
                case 52:
                    outy = "Barbados";
                    break;
                case 112:
                    outy = "Belarus";
                    break;
                case 56:
                    outy = "Belgium";
                    break;
                case 84:
                    outy = "Belize";
                    break;
                case 204:
                    outy = "Benin";
                    break;
                case 60:
                    outy = "Bermuda";
                    break;
                case 64:
                    outy = "Bhutan";
                    break;
                case 68:
                    outy = "Bolivia";
                    break;
                case 70:
                    outy = "Bosnia and Herzegovina";
                    break;
                case 72:
                    outy = "Botswana";
                    break;
                case 74:
                    outy = "Bouvet Island";
                    break;
                case 76:
                    outy = "Brazil";
                    break;
                case 86:
                    outy = "British Indian Ocean Territory";
                    break;
                case 92:
                    outy = "British Virgin Islands";
                    break;
                case 96:
                    outy = "Brunei Darussalam";
                    break;
                case 100:
                    outy = "Bulgaria";
                    break;
                case 854:
                    outy = "Burkina Faso";
                    break;
                case 108:
                    outy = "Burundi";
                    break;
                case 116:
                    outy = "Cambodia";
                    break;
                case 120:
                    outy = "Cameroon";
                    break;
                case 124:
                    outy = "Canada";
                    break;
                case 132:
                    outy = "Cape Verde";
                    break;
                case 136:
                    outy = "Cayman Islands";
                    break;
                case 140:
                    outy = "Central African Republic";
                    break;
                case 148:
                    outy = "Chad";
                    break;
                case 152:
                    outy = "Chile";
                    break;
                case 156:
                    outy = "China";
                    break;
                case 162:
                    outy = "Christmas Island";
                    break;
                case 166:
                    outy = "Cocos (Keeling) Islands";
                    break;
                case 170:
                    outy = "Colombia";
                    break;
                case 174:
                    outy = "Comoros";
                    break;
                case 178:
                    outy = "Congo (Brazzaville)";
                    break;
                case 180:
                    outy = "Congo (Democratic Republic of)";
                    break;
                case 184:
                    outy = "Cook Islands";
                    break;
                case 188:
                    outy = "Costa Rica";
                    break;
                case 191:
                    outy = "Croatia";
                    break;
                case 192:
                    outy = "Cuba";
                    break;
                case 196:
                    outy = "Cyprus";
                    break;
                case 203:
                    outy = "Czech Republic";
                    break;
                case 384:
                    outy = "Côte dIvoire";
                    break;
                case 208:
                    outy = "Denmark";
                    break;
                case 262:
                    outy = "Djibouti";
                    break;
                case 212:
                    outy = "Dominica";
                    break;
                case 214:
                    outy = "Dominican Republic";
                    break;
                case 218:
                    outy = "Ecuador";
                    break;
                case 818:
                    outy = "Egypt";
                    break;
                case 222:
                    outy = "El Salvador";
                    break;
                case 226:
                    outy = "Equatorial Guinea";
                    break;
                case 232:
                    outy = "Eritrea";
                    break;
                case 233:
                    outy = "Estonia";
                    break;
                case 231:
                    outy = "Ethiopia";
                    break;
                case 238:
                    outy = "Falkland Islands (Malvinas)";
                    break;
                case 234:
                    outy = "Faroe Islands";
                    break;
                case 242:
                    outy = "Fiji";
                    break;
                case 246:
                    outy = "Finland";
                    break;
                case 250:
                    outy = "France";
                    break;
                case 254:
                    outy = "French Guiana";
                    break;
                case 258:
                    outy = "French Polynesia";
                    break;
                case 260:
                    outy = "French Southern Territories";
                    break;
                case 266:
                    outy = "Gabon";
                    break;
                case 270:
                    outy = "Gambia";
                    break;
                case 268:
                    outy = "Georgia";
                    break;
                case 276:
                    outy = "Germany";
                    break;
                case 288:
                    outy = "Ghana";
                    break;
                case 292:
                    outy = "Gibraltar";
                    break;
                case 300:
                    outy = "Greece";
                    break;
                case 304:
                    outy = "Greenland";
                    break;
                case 308:
                    outy = "Grenada";
                    break;
                case 312:
                    outy = "Guadeloupe";
                    break;
                case 316:
                    outy = "Guam";
                    break;
                case 320:
                    outy = "Guatemala";
                    break;
                case 831:
                    outy = "Guernsey";
                    break;
                case 324:
                    outy = "Guinea";
                    break;
                case 624:
                    outy = "Guinea Bissau";
                    break;
                case 328:
                    outy = "Guyana";
                    break;
                case 332:
                    outy = "Haiti";
                    break;
                case 334:
                    outy = "Heard Island and Mcdonald Islands";
                    break;
                case 336:
                    outy = "Holy See (Vatican City State)";
                    break;
                case 340:
                    outy = "Honduras";
                    break;
                case 344:
                    outy = "Hong Kong (SAR of China)";
                    break;
                case 348:
                    outy = "Hungary";
                    break;
                case 352:
                    outy = "Iceland";
                    break;
                case 356:
                    outy = "India";
                    break;
                case 360:
                    outy = "Indonesia";
                    break;
                case 364:
                    outy = "Iran (Islamic Republic of)";
                    break;
                case 368:
                    outy = "Iraq";
                    break;
                case 372:
                    outy = "Ireland";
                    break;
                case 833:
                    outy = "Isle of Man";
                    break;
                case 376:
                    outy = "Israel";
                    break;
                case 380:
                    outy = "Italy";
                    break;
                case 388:
                    outy = "Jamaica";
                    break;
                case 392:
                    outy = "Japan";
                    break;
                case 832:
                    outy = "Jersey";
                    break;
                case 400:
                    outy = "Jordan";
                    break;
                case 398:
                    outy = "Kazakhstan";
                    break;
                case 404:
                    outy = "Kenya";
                    break;
                case 296:
                    outy = "Kiribati";
                    break;
                case 408:
                    outy = "Korea (North)";
                    break;
                case 410:
                    outy = "Korea (South)";
                    break;
                case 414:
                    outy = "Kuwait";
                    break;
                case 417:
                    outy = "Kyrgyzstan";
                    break;
                case 418:
                    outy = "Lao PDR";
                    break;
                case 428:
                    outy = "Latvia";
                    break;
                case 422:
                    outy = "Lebanon";
                    break;
                case 426:
                    outy = "Lesotho";
                    break;
                case 430:
                    outy = "Liberia";
                    break;
                case 434:
                    outy = "Libya";
                    break;
                case 438:
                    outy = "Liechtenstein";
                    break;
                case 440:
                    outy = "Lithuania";
                    break;
                case 442:
                    outy = "Luxembourg";
                    break;
                case 446:
                    outy = "Macao (SAR of China)";
                    break;
                case 807:
                    outy = "Macedonia (Republic of)";
                    break;
                case 450:
                    outy = "Madagascar";
                    break;
                case 454:
                    outy = "Malawi";
                    break;
                case 458:
                    outy = "Malaysia";
                    break;
                case 462:
                    outy = "Maldives";
                    break;
                case 466:
                    outy = "Mali";
                    break;
                case 470:
                    outy = "Malta";
                    break;
                case 584:
                    outy = "Marshall Islands";
                    break;
                case 474:
                    outy = "Martinique";
                    break;
                case 478:
                    outy = "Mauritania";
                    break;
                case 480:
                    outy = "Mauritius";
                    break;
                case 175:
                    outy = "Mayotte";
                    break;
                case 484:
                    outy = "Mexico";
                    break;
                case 583:
                    outy = "Micronesia (Federated States of)";
                    break;
                case 498:
                    outy = "Moldova";
                    break;
                case 492:
                    outy = "Monaco";
                    break;
                case 496:
                    outy = "Mongolia";
                    break;
                case 499:
                    outy = "Montenegro";
                    break;
                case 500:
                    outy = "Montserrat";
                    break;
                case 504:
                    outy = "Morocco";
                    break;
                case 508:
                    outy = "Mozambique";
                    break;
                case 104:
                    outy = "Myanmar";
                    break;
                case 516:
                    outy = "Namibia";
                    break;
                case 520:
                    outy = "Nauru";
                    break;
                case 524:
                    outy = "Nepal";
                    break;
                case 528:
                    outy = "Netherlands";
                    break;
                case 530:
                    outy = "Netherlands Antilles";
                    break;
                case 540:
                    outy = "New Caledonia";
                    break;
                case 554:
                    outy = "New Zealand";
                    break;
                case 558:
                    outy = "Nicaragua";
                    break;
                case 562:
                    outy = "Niger";
                    break;
                case 566:
                    outy = "Nigeria";
                    break;
                case 570:
                    outy = "Niue";
                    break;
                case 574:
                    outy = "Norfolk Island";
                    break;
                case 580:
                    outy = "Northern Mariana Islands";
                    break;
                case 578:
                    outy = "Norway";
                    break;
                case 512:
                    outy = "Oman";
                    break;
                case 586:
                    outy = "Pakistan";
                    break;
                case 585:
                    outy = "Palau";
                    break;
                case 275:
                    outy = "Palestinian Territory";
                    break;
                case 591:
                    outy = "Panama";
                    break;
                case 598:
                    outy = "Papua New Guinea";
                    break;
                case 600:
                    outy = "Paraguay";
                    break;
                case 604:
                    outy = "Peru";
                    break;
                case 608:
                    outy = "Philippines";
                    break;
                case 612:
                    outy = "Pitcairn";
                    break;
                case 616:
                    outy = "Poland";
                    break;
                case 620:
                    outy = "Portugal";
                    break;
                case 630:
                    outy = "Puerto Rico";
                    break;
                case 634:
                    outy = "Qatar";
                    break;
                case 642:
                    outy = "Romania";
                    break;
                case 643:
                    outy = "Russian Federation";
                    break;
                case 646:
                    outy = "Rwanda";
                    break;
                case 638:
                    outy = "Réunion";
                    break;
                case 654:
                    outy = "Saint Helena";
                    break;
                case 659:
                    outy = "Saint Kitts and Nevis";
                    break;
                case 662:
                    outy = "Saint Lucia";
                    break;
                case 666:
                    outy = "Saint Pierre and Miquelon";
                    break;
                case 670:
                    outy = "Saint Vincent and Grenadines";
                    break;
                case 652:
                    outy = "Saint Barthélemy";
                    break;
                case 663:
                    outy = "Saint Martin (French part)";
                    break;
                case 882:
                    outy = "Samoa";
                    break;
                case 674:
                    outy = "San Marino";
                    break;
                case 678:
                    outy = "Sao Tome and Principe";
                    break;
                case 682:
                    outy = "Saudi Arabia";
                    break;
                case 686:
                    outy = "Senegal";
                    break;
                case 688:
                    outy = "Serbia";
                    break;
                case 690:
                    outy = "Seychelles";
                    break;
                case 694:
                    outy = "Sierra Leone";
                    break;
                case 702:
                    outy = "Singapore";
                    break;
                case 703:
                    outy = "Slovakia";
                    break;
                case 705:
                    outy = "Slovenia";
                    break;
                case 90:
                    outy = "Solomon Islands";
                    break;
                case 706:
                    outy = "Somalia";
                    break;
                case 710:
                    outy = "South Africa";
                    break;
                case 239:
                    outy = "South Georgia and the South Sandwich Islands";
                    break;
                case 728:
                    outy = "South Sudan";
                    break;
                case 724:
                    outy = "Spain";
                    break;
                case 144:
                    outy = "Sri Lanka";
                    break;
                case 736:
                    outy = "Sudan";
                    break;
                case 740:
                    outy = "Suriname";
                    break;
                case 744:
                    outy = "Svalbard and Jan Mayen Islands";
                    break;
                case 748:
                    outy = "Swaziland";
                    break;
                case 752:
                    outy = "Sweden";
                    break;
                case 756:
                    outy = "Switzerland";
                    break;
                case 760:
                    outy = "Syrian Arab Republic";
                    break;
                case 158:
                    outy = "Taiwan Republic of China";
                    break;
                case 762:
                    outy = "Tajikistan";
                    break;
                case 834:
                    outy = "Tanzania United Republic of";
                    break;
                case 764:
                    outy = "Thailand";
                    break;
                case 626:
                    outy = "Timor Leste";
                    break;
                case 768:
                    outy = "Togo";
                    break;
                case 772:
                    outy = "Tokelau";
                    break;
                case 776:
                    outy = "Tonga";
                    break;
                case 780:
                    outy = "Trinidad and Tobago";
                    break;
                case 788:
                    outy = "Tunisia";
                    break;
                case 792:
                    outy = "Turkey";
                    break;
                case 795:
                    outy = "Turkmenistan";
                    break;
                case 796:
                    outy = "Turks and Caicos Islands";
                    break;
                case 798:
                    outy = "Tuvalu";
                    break;
                case 800:
                    outy = "Uganda";
                    break;
                case 804:
                    outy = "Ukraine";
                    break;
                case 784:
                    outy = "United Arab Emirates";
                    break;
                case 826:
                    outy = "United Kingdom";
                    break;
                case 581:
                    outy = "United States Minor Outlying Islands";
                    break;
                case 840:
                    outy = "United States of America";
                    break;
                case 858:
                    outy = "Uruguay";
                    break;
                case 860:
                    outy = "Uzbekistan";
                    break;
                case 548:
                    outy = "Vanuatu";
                    break;
                case 862:
                    outy = "Venezuela (Bolivarian Republic of)";
                    break;
                case 704:
                    outy = "Viet Nam";
                    break;
                case 850:
                    outy = "Virgin Islands US";
                    break;
                case 876:
                    outy = "Wallis and Futuna Islands ";
                    break;
                case 732:
                    outy = "Western Sahara";
                    break;
                case 887:
                    outy = "Yemen";
                    break;
                case 894:
                    outy = "Zambia";
                    break;
                case 716:
                    outy = "Zimbabwe";
                    break;

            }
            return outy;
        }


        public CountriesDAO() { 
            _cunts = new CountryList();
            _cunts.Items.Add(new CountryItem(4,"Afghanistan","AF","AFG"));
            _cunts.Items.Add(new CountryItem(248,"Aland Islands","AX","ALA"));
            _cunts.Items.Add(new CountryItem(8,"Albania","AL","ALB"));
            _cunts.Items.Add(new CountryItem(12,"Algeria","DZ","DZA"));
            _cunts.Items.Add(new CountryItem(16,"American Samoa","AS","ASM"));
            _cunts.Items.Add(new CountryItem(20,"Andorra","AD","AND"));
            _cunts.Items.Add(new CountryItem(24,"Angola","AO","AGO"));
            _cunts.Items.Add(new CountryItem(660,"Anguilla","AI","AIA"));
            _cunts.Items.Add(new CountryItem(10,"Antarctica","AQ","ATA"));
            _cunts.Items.Add(new CountryItem(28,"Antigua and Barbuda","AG","ATG"));
            _cunts.Items.Add(new CountryItem(32,"Argentina","AR","ARG"));
            _cunts.Items.Add(new CountryItem(51,"Armenia","AM","ARM"));
            _cunts.Items.Add(new CountryItem(533,"Aruba","AW","ABW"));
            _cunts.Items.Add(new CountryItem(36,"Australia","AU","AUS"));
            _cunts.Items.Add(new CountryItem(40,"Austria","AT","AUT"));
            _cunts.Items.Add(new CountryItem(31,"Azerbaijan","AZ","AZE"));
            _cunts.Items.Add(new CountryItem(44,"Bahamas","BS","BHS"));
            _cunts.Items.Add(new CountryItem(48,"Bahrain","BH","BHR"));
            _cunts.Items.Add(new CountryItem(50,"Bangladesh","BD","BGD"));
            _cunts.Items.Add(new CountryItem(52,"Barbados","BB","BRB"));
            _cunts.Items.Add(new CountryItem(112,"Belarus","BY","BLR"));
            _cunts.Items.Add(new CountryItem(56,"Belgium","BE","BEL"));
            _cunts.Items.Add(new CountryItem(84,"Belize","BZ","BLZ"));
            _cunts.Items.Add(new CountryItem(204,"Benin","BJ","BEN"));
            _cunts.Items.Add(new CountryItem(60,"Bermuda","BM","BMU"));
            _cunts.Items.Add(new CountryItem(64,"Bhutan","BT","BTN"));
            _cunts.Items.Add(new CountryItem(68,"Bolivia","BO","BOL"));
            _cunts.Items.Add(new CountryItem(70,"Bosnia and Herzegovina","BA","BIH"));
            _cunts.Items.Add(new CountryItem(72,"Botswana","BW","BWA"));
            _cunts.Items.Add(new CountryItem(74,"Bouvet Island","BV","BVT"));
            _cunts.Items.Add(new CountryItem(76,"Brazil","BR","BRA"));
            _cunts.Items.Add(new CountryItem(92,"British Virgin Islands","VG","VGB"));
            _cunts.Items.Add(new CountryItem(86,"British Indian Ocean Territory","IO","IOT"));
            _cunts.Items.Add(new CountryItem(96,"Brunei Darussalam","BN","BRN"));
            _cunts.Items.Add(new CountryItem(100,"Bulgaria","BG","BGR"));
            _cunts.Items.Add(new CountryItem(854,"Burkina Faso","BF","BFA"));
            _cunts.Items.Add(new CountryItem(108,"Burundi","BI","BDI"));
            _cunts.Items.Add(new CountryItem(116,"Cambodia","KH","KHM"));
            _cunts.Items.Add(new CountryItem(120,"Cameroon","CM","CMR"));
            _cunts.Items.Add(new CountryItem(124,"Canada","CA","CAN"));
            _cunts.Items.Add(new CountryItem(132,"Cape Verde","CV","CPV"));
            _cunts.Items.Add(new CountryItem(136,"Cayman Islands ","KY","CYM"));
            _cunts.Items.Add(new CountryItem(140,"Central African Republic","CF","CAF"));
            _cunts.Items.Add(new CountryItem(148,"Chad","TD","TCD"));
            _cunts.Items.Add(new CountryItem(152,"Chile","CL","CHL"));
            _cunts.Items.Add(new CountryItem(156,"China","CN","CHN"));
            _cunts.Items.Add(new CountryItem(344,"Hong Kong (SAR China)","HK","HKG"));
            _cunts.Items.Add(new CountryItem(446,"Macao (SAR China)","MO","MAC"));
            _cunts.Items.Add(new CountryItem(162,"Christmas Island","CX","CXR"));
            _cunts.Items.Add(new CountryItem(166,"Cocos (Keeling) Islands","CC","CCK"));
            _cunts.Items.Add(new CountryItem(170,"Colombia","CO","COL"));
            _cunts.Items.Add(new CountryItem(174,"Comoros","KM","COM"));
            _cunts.Items.Add(new CountryItem(178,"Congo (Brazzaville)","CG","COG"));
            _cunts.Items.Add(new CountryItem(180,"Congo (Kinshasa)","CD","COD"));
            _cunts.Items.Add(new CountryItem(184,"Cook Islands ","CK","COK"));
            _cunts.Items.Add(new CountryItem(188,"Costa Rica","CR","CRI"));
            _cunts.Items.Add(new CountryItem(384,"Côte d'Ivoire","CI","CIV"));
            _cunts.Items.Add(new CountryItem(191,"Croatia","HR","HRV"));
            _cunts.Items.Add(new CountryItem(192,"Cuba","CU","CUB"));
            _cunts.Items.Add(new CountryItem(196,"Cyprus","CY","CYP"));
            _cunts.Items.Add(new CountryItem(203,"Czech Republic","CZ","CZE"));
            _cunts.Items.Add(new CountryItem(208,"Denmark","DK","DNK"));
            _cunts.Items.Add(new CountryItem(262,"Djibouti","DJ","DJI"));
            _cunts.Items.Add(new CountryItem(212,"Dominica","DM","DMA"));
            _cunts.Items.Add(new CountryItem(214,"Dominican Republic","DO","DOM"));
            _cunts.Items.Add(new CountryItem(218,"Ecuador","EC","ECU"));
            _cunts.Items.Add(new CountryItem(818,"Egypt","EG","EGY"));
            _cunts.Items.Add(new CountryItem(222,"El Salvador","SV","SLV"));
            _cunts.Items.Add(new CountryItem(226,"Equatorial Guinea","GQ","GNQ"));
            _cunts.Items.Add(new CountryItem(232,"Eritrea","ER","ERI"));
            _cunts.Items.Add(new CountryItem(233,"Estonia","EE","EST"));
            _cunts.Items.Add(new CountryItem(231,"Ethiopia","ET","ETH"));
            _cunts.Items.Add(new CountryItem(238,"Falkland Islands (Malvinas) ","FK","FLK"));
            _cunts.Items.Add(new CountryItem(234,"Faroe Islands","FO","FRO"));
            _cunts.Items.Add(new CountryItem(242,"Fiji","FJ","FJI"));
            _cunts.Items.Add(new CountryItem(246,"Finland","FI","FIN"));
            _cunts.Items.Add(new CountryItem(250,"France","FR","FRA"));
            _cunts.Items.Add(new CountryItem(254,"French Guiana","GF","GUF"));
            _cunts.Items.Add(new CountryItem(258,"French Polynesia","PF","PYF"));
            _cunts.Items.Add(new CountryItem(260,"French Southern Territories","TF","ATF"));
            _cunts.Items.Add(new CountryItem(266,"Gabon","GA","GAB"));
            _cunts.Items.Add(new CountryItem(270,"Gambia","GM","GMB"));
            _cunts.Items.Add(new CountryItem(268,"Georgia","GE","GEO"));
            _cunts.Items.Add(new CountryItem(276,"Germany","DE","DEU"));
            _cunts.Items.Add(new CountryItem(288,"Ghana","GH","GHA"));
            _cunts.Items.Add(new CountryItem(292,"Gibraltar ","GI","GIB"));
            _cunts.Items.Add(new CountryItem(300,"Greece","GR","GRC"));
            _cunts.Items.Add(new CountryItem(304,"Greenland","GL","GRL"));
            _cunts.Items.Add(new CountryItem(308,"Grenada","GD","GRD"));
            _cunts.Items.Add(new CountryItem(312,"Guadeloupe","GP","GLP"));
            _cunts.Items.Add(new CountryItem(316,"Guam","GU","GUM"));
            _cunts.Items.Add(new CountryItem(320,"Guatemala","GT","GTM"));
            _cunts.Items.Add(new CountryItem(831,"Guernsey","GG","GGY"));
            _cunts.Items.Add(new CountryItem(324,"Guinea","GN","GIN"));
            _cunts.Items.Add(new CountryItem(624,"Guinea-Bissau","GW","GNB"));
            _cunts.Items.Add(new CountryItem(328,"Guyana","GY","GUY"));
            _cunts.Items.Add(new CountryItem(332,"Haiti","HT","HTI"));
            _cunts.Items.Add(new CountryItem(334,"Heard and Mcdonald Islands","HM","HMD"));
            _cunts.Items.Add(new CountryItem(336,"Holy See (Vatican City State)","VA","VAT"));
            _cunts.Items.Add(new CountryItem(340,"Honduras","HN","HND"));
            _cunts.Items.Add(new CountryItem(348,"Hungary","HU","HUN"));
            _cunts.Items.Add(new CountryItem(352,"Iceland","IS","ISL"));
            _cunts.Items.Add(new CountryItem(356,"India","IN","IND"));
            _cunts.Items.Add(new CountryItem(360,"Indonesia","ID","IDN"));
            _cunts.Items.Add(new CountryItem(364,"Iran (Islamic Republic of)","IR","IRN"));
            _cunts.Items.Add(new CountryItem(368,"Iraq","IQ","IRQ"));
            _cunts.Items.Add(new CountryItem(372,"Ireland","IE","IRL"));
            _cunts.Items.Add(new CountryItem(833,"Isle of Man ","IM","IMN"));
            _cunts.Items.Add(new CountryItem(376,"Israel","IL","ISR"));
            _cunts.Items.Add(new CountryItem(380,"Italy","IT","ITA"));
            _cunts.Items.Add(new CountryItem(388,"Jamaica","JM","JAM"));
            _cunts.Items.Add(new CountryItem(392,"Japan","JP","JPN"));
            _cunts.Items.Add(new CountryItem(832,"Jersey","JE","JEY"));
            _cunts.Items.Add(new CountryItem(400,"Jordan","JO","JOR"));
            _cunts.Items.Add(new CountryItem(398,"Kazakhstan","KZ","KA/Z"));
            _cunts.Items.Add(new CountryItem(404,"Kenya","KE","KEN"));
            _cunts.Items.Add(new CountryItem(296,"Kiribati","KI","KIR"));
            _cunts.Items.Add(new CountryItem(408,"Korea (North)","KP","PRK"));
            _cunts.Items.Add(new CountryItem(410,"Korea (South)","KR","KOR"));
            _cunts.Items.Add(new CountryItem(414,"Kuwait","KW","KWT"));
            _cunts.Items.Add(new CountryItem(417,"Kyrgyzstan","KG","KGZ"));
            _cunts.Items.Add(new CountryItem(418,"Lao PDR","LA","LAO"));
            _cunts.Items.Add(new CountryItem(428,"Latvia","LV","LVA"));
            _cunts.Items.Add(new CountryItem(422,"Lebanon","LB","LBN"));
            _cunts.Items.Add(new CountryItem(426,"Lesotho","LS","LSO"));
            _cunts.Items.Add(new CountryItem(430,"Liberia","LR","LBR"));
            _cunts.Items.Add(new CountryItem(434,"Libya","LY","LBY"));
            _cunts.Items.Add(new CountryItem(438,"Liechtenstein","LI","LIE"));
            _cunts.Items.Add(new CountryItem(440,"Lithuania","LT","LTU"));
            _cunts.Items.Add(new CountryItem(442,"Luxembourg","LU","LUX"));
            _cunts.Items.Add(new CountryItem(807,"Macedonia (Republic of)","MK","MKD"));
            _cunts.Items.Add(new CountryItem(450,"Madagascar","MG","MDG"));
            _cunts.Items.Add(new CountryItem(454,"Malawi","MW","MWI"));
            _cunts.Items.Add(new CountryItem(458,"Malaysia","MY","MYS"));
            _cunts.Items.Add(new CountryItem(462,"Maldives","MV","MDV"));
            _cunts.Items.Add(new CountryItem(466,"Mali","ML","MLI"));
            _cunts.Items.Add(new CountryItem(470,"Malta","MT","MLT"));
            _cunts.Items.Add(new CountryItem(584,"Marshall Islands","MH","MHL"));
            _cunts.Items.Add(new CountryItem(474,"Martinique","MQ","MTQ"));
            _cunts.Items.Add(new CountryItem(478,"Mauritania","MR","MRT"));
            _cunts.Items.Add(new CountryItem(480,"Mauritius","MU","MUS"));
            _cunts.Items.Add(new CountryItem(175,"Mayotte","YT","MYT"));
            _cunts.Items.Add(new CountryItem(484,"Mexico","MX","MEX"));
            _cunts.Items.Add(new CountryItem(583,"Micronesia (Federated States of)","FM","FSM"));
            _cunts.Items.Add(new CountryItem(498,"Moldova","MD","MDA"));
            _cunts.Items.Add(new CountryItem(492,"Monaco","MC","MCO"));
            _cunts.Items.Add(new CountryItem(496,"Mongolia","MN","MNG"));
            _cunts.Items.Add(new CountryItem(499,"Montenegro","ME","MNE"));
            _cunts.Items.Add(new CountryItem(500,"Montserrat","MS","MSR"));
            _cunts.Items.Add(new CountryItem(504,"Morocco","MA","MAR"));
            _cunts.Items.Add(new CountryItem(508,"Mozambique","MZ","MOZ"));
            _cunts.Items.Add(new CountryItem(104,"Myanmar","MM","MMR"));
            _cunts.Items.Add(new CountryItem(516,"Namibia","NA","NAM"));
            _cunts.Items.Add(new CountryItem(520,"Nauru","NR","NRU"));
            _cunts.Items.Add(new CountryItem(524,"Nepal","NP","NPL"));
            _cunts.Items.Add(new CountryItem(528,"Netherlands","NL","NLD"));
            _cunts.Items.Add(new CountryItem(530,"Netherlands Antilles","AN","ANT"));
            _cunts.Items.Add(new CountryItem(540,"New Caledonia","NC","NCL"));
            _cunts.Items.Add(new CountryItem(554,"New Zealand","NZ","NZL"));
            _cunts.Items.Add(new CountryItem(558,"Nicaragua","NI","NIC"));
            _cunts.Items.Add(new CountryItem(562,"Niger","NE","NER"));
            _cunts.Items.Add(new CountryItem(566,"Nigeria","NG","NGA"));
            _cunts.Items.Add(new CountryItem(570,"Niue ","NU","NIU"));
            _cunts.Items.Add(new CountryItem(574,"Norfolk Island","NF","NFK"));
            _cunts.Items.Add(new CountryItem(580,"Northern Mariana Islands","MP","MNP"));
            _cunts.Items.Add(new CountryItem(578,"Norway","NO","NOR"));
            _cunts.Items.Add(new CountryItem(512,"Oman","OM","OMN"));
            _cunts.Items.Add(new CountryItem(586,"Pakistan","PK","PAK"));
            _cunts.Items.Add(new CountryItem(585,"Palau","PW","PLW"));
            _cunts.Items.Add(new CountryItem(275,"Palestinian Territory","PS","PSE"));
            _cunts.Items.Add(new CountryItem(591,"Panama","PA","PAN"));
            _cunts.Items.Add(new CountryItem(598,"Papua New Guinea","PG","PNG"));
            _cunts.Items.Add(new CountryItem(600,"Paraguay","PY","PRY"));
            _cunts.Items.Add(new CountryItem(604,"Peru","PE","PER"));
            _cunts.Items.Add(new CountryItem(608,"Philippines","PH","PHL"));
            _cunts.Items.Add(new CountryItem(612,"Pitcairn","PN","PCN"));
            _cunts.Items.Add(new CountryItem(616,"Poland","PL","POL"));
            _cunts.Items.Add(new CountryItem(620,"Portugal","PT","PRT"));
            _cunts.Items.Add(new CountryItem(630,"Puerto Rico","PR","PRI"));
            _cunts.Items.Add(new CountryItem(634,"Qatar","QA","QAT"));
            _cunts.Items.Add(new CountryItem(638,"Réunion","RE","REU"));
            _cunts.Items.Add(new CountryItem(642,"Romania","RO","ROU"));
            _cunts.Items.Add(new CountryItem(643,"Russian Federation","RU","RUS"));
            _cunts.Items.Add(new CountryItem(646,"Rwanda","RW","RWA"));
            _cunts.Items.Add(new CountryItem(652,"Saint-Barthélemy","BL","BLM"));
            _cunts.Items.Add(new CountryItem(654,"Saint Helena","SH","SHN"));
            _cunts.Items.Add(new CountryItem(659,"Saint Kitts and Nevis","KN","KNA"));
            _cunts.Items.Add(new CountryItem(662,"Saint Lucia","LC","LCA"));
            _cunts.Items.Add(new CountryItem(663,"Saint-Martin (French part)","MF","MAF"));
            _cunts.Items.Add(new CountryItem(666,"Saint Pierre and Miquelon ","PM","SPM"));
            _cunts.Items.Add(new CountryItem(670,"Saint Vincent and Grenadines","VC","VCT"));
            _cunts.Items.Add(new CountryItem(882,"Samoa","WS","WSM"));
            _cunts.Items.Add(new CountryItem(674,"San Marino","SM","SMR"));
            _cunts.Items.Add(new CountryItem(678,"Sao Tome and Principe","ST","STP"));
            _cunts.Items.Add(new CountryItem(682,"Saudi Arabia","SA","SAU"));
            _cunts.Items.Add(new CountryItem(686,"Senegal","SN","SEN"));
            _cunts.Items.Add(new CountryItem(688,"Serbia","RS","SRB"));
            _cunts.Items.Add(new CountryItem(690,"Seychelles","SC","SYC"));
            _cunts.Items.Add(new CountryItem(694,"Sierra Leone","SL","SLE"));
            _cunts.Items.Add(new CountryItem(702,"Singapore","SG","SGP"));
            _cunts.Items.Add(new CountryItem(703,"Slovakia","SK","SVK"));
            _cunts.Items.Add(new CountryItem(705,"Slovenia","SI","SVN"));
            _cunts.Items.Add(new CountryItem(90,"Solomon Islands","SB","SLB"));
            _cunts.Items.Add(new CountryItem(706,"Somalia","SO","SOM"));
            _cunts.Items.Add(new CountryItem(710,"South Africa","ZA","ZAF"));
            _cunts.Items.Add(new CountryItem(239,"South Georgia and the South Sandwich Islands","GS","SGS"));
            _cunts.Items.Add(new CountryItem(728,"South Sudan","SS","SSD"));
            _cunts.Items.Add(new CountryItem(724,"Spain","ES","ESP"));
            _cunts.Items.Add(new CountryItem(144,"Sri Lanka","LK","LKA"));
            _cunts.Items.Add(new CountryItem(736,"Sudan","SD","SDN"));
            _cunts.Items.Add(new CountryItem(740,"Suriname","SR","SUR"));
            _cunts.Items.Add(new CountryItem(744,"Svalbard and Jan Mayen Islands ","SJ","SJM"));
            _cunts.Items.Add(new CountryItem(748,"Swaziland","SZ","SWZ"));
            _cunts.Items.Add(new CountryItem(752,"Sweden","SE","SWE"));
            _cunts.Items.Add(new CountryItem(756,"Switzerland","CH","CHE"));
            _cunts.Items.Add(new CountryItem(760,"Syrian Arab Republic (Syria)","SY","SYR"));
            _cunts.Items.Add(new CountryItem(158,"Taiwan (Republic of China)","TW","TWN"));
            _cunts.Items.Add(new CountryItem(762,"Tajikistan","TJ","TJK"));
            _cunts.Items.Add(new CountryItem(834,"Tanzania (United Republic of)","TZ","TZA"));
            _cunts.Items.Add(new CountryItem(764,"Thailand","TH","THA"));
            _cunts.Items.Add(new CountryItem(626,"Timor-Leste","TL","TLS"));
            _cunts.Items.Add(new CountryItem(768,"Togo","TG","TGO"));
            _cunts.Items.Add(new CountryItem(772,"Tokelau ","TK","TKL"));
            _cunts.Items.Add(new CountryItem(776,"Tonga","TO","TON"));
            _cunts.Items.Add(new CountryItem(780,"Trinidad and Tobago","TT","TTO"));
            _cunts.Items.Add(new CountryItem(788,"Tunisia","TN","TUN"));
            _cunts.Items.Add(new CountryItem(792,"Turkey","TR","TUR"));
            _cunts.Items.Add(new CountryItem(795,"Turkmenistan","TM","TKM"));
            _cunts.Items.Add(new CountryItem(796,"Turks and Caicos Islands ","TC","TCA"));
            _cunts.Items.Add(new CountryItem(798,"Tuvalu","TV","TUV"));
            _cunts.Items.Add(new CountryItem(800,"Uganda","UG","UGA"));
            _cunts.Items.Add(new CountryItem(804,"Ukraine","UA","UKR"));
            _cunts.Items.Add(new CountryItem(784,"United Arab Emirates","AE","ARE"));
            _cunts.Items.Add(new CountryItem(826,"United Kingdom","GB","GBR"));
            _cunts.Items.Add(new CountryItem(840,"United States of America","US","USA"));
            _cunts.Items.Add(new CountryItem(581,"US Minor Outlying Islands","UM","UMI"));
            _cunts.Items.Add(new CountryItem(858,"Uruguay","UY","URY"));
            _cunts.Items.Add(new CountryItem(860,"Uzbekistan","UZ","UZB"));
            _cunts.Items.Add(new CountryItem(548,"Vanuatu","VU","VUT"));
            _cunts.Items.Add(new CountryItem(862,"Venezuela (Bolivarian Republic)","VE","VEN"));
            _cunts.Items.Add(new CountryItem(704,"Viet Nam","VN","VNM"));
            _cunts.Items.Add(new CountryItem(850,"Virgin Islands (US)","VI","VIR"));
            _cunts.Items.Add(new CountryItem(876,"Wallis and Futuna Islands ","WF","WLF"));
            _cunts.Items.Add(new CountryItem(732,"Western Sahara","EH","ESH"));
            _cunts.Items.Add(new CountryItem(887,"Yemen","YE","YEM"));
            _cunts.Items.Add(new CountryItem(894,"Zambia","ZM","ZMB"));
            _cunts.Items.Add(new CountryItem(716, "Zimbabwe", "ZW", "ZWE"));

        }


    }
}
