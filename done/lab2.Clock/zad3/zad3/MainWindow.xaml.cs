﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zad3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Мерку́рий — наименьшая планета Солнечной системы и самая близкая к Солнцу. Названа в честь древнеримского бога торговли — быстрого Меркурия, поскольку она движется по небу быстрее других планет. Её период обращения вокруг Солнца составляет всего 87,97 земных суток — самый короткий среди всех планет Солнечной системы.\r\n\r\nВидимое расстояние Меркурия от Солнца, если смотреть с Земли, никогда не превышает 28°. Эта близость к Солнцу означает, что планету можно увидеть только в течение небольшого времени после захода или до восхода солнца, обычно в сумерках. В телескоп у Меркурия можно увидеть фазы, изменяющиеся от тонкого серпа до почти полного диска, как у Венеры и Луны, а иногда он проходит по диску Солнца. Период изменения фаз Меркурия равен синодическому периоду его обращения — примерно 116 дней.\r\n\r\nОсь Меркурия имеет наименьший наклон из всех планет Солнечной системы (около 1/30°). Однако эксцентриситет орбиты у него максимальный среди них, и поэтому в перигелии расстояние Меркурия от Солнца составляет всего около двух третей (66 %) от его расстояния в афелии. Поверхность Меркурия покрыта ударными кратерами и внешне похожа на лунную, что указывает на отсутствие внутренней геологической активности в последние миллиарды лет. Поскольку атмосферы у Меркурия почти нет, температура его поверхности меняется сильнее, чем на любой другой планете Солнечной системы: от 100 К (−173 °C) ночью до 700 К (+427 °C) днём в экваториальных регионах[12]. Полярные области постоянно охлаждены ниже 180 К (−93 °С)[10]. Известных природных спутников у планеты нет.";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Вене́ра — вторая по удалённости от Солнца и шестая по размеру планета Солнечной системы, наряду с Меркурием, Землёй и Марсом принадлежащая к семейству планет земной группы. Названа в честь древнеримской богини любви Венеры[7]. По ряду характеристик — например, по массе и размерам — Венера считается «сестрой» Земли[8]. Венерианский год составляет 224,7 земных суток. Она имеет самый длинный период вращения вокруг своей оси (около 243 земных суток, в среднем 243,0212 ± 0,00006 сут[9]) среди всех планет Солнечной системы и вращается в направлении, противоположном направлению вращения большинства планет.\r\n\r\nВенера не имеет естественных спутников. На земном небе Венера является третьим по яркости светилом после Солнца и Луны. Её яркость достигает видимой звёздной величины −4,6m и является достаточной, чтобы ночью отбрасывать различимые тени. Изредка Венера видна невооружённым глазом и в светлое время суток.Перейти к разделу «#Астрономические характеристики»\r\n\r\nВенера имеет плотную атмосферу, состоящую более чем на 96 % из углекислого газа. Атмосферное давление на поверхности планеты в 92 раза больше, чем на поверхности Земли, и примерно равно давлению воды на глубине 900 метров. Из-за высокого давления углекислый газ в приповерхностной части атмосферы по агрегатному состоянию является уже не газом, а сверхкритической жидкостью, поэтому эта часть атмосферы представляет собой «полужидкий-полугазообразный» океан из сверхкритического углекислого газа. Средняя температура поверхности Венеры — 735 К (462 °C), что делает её самой горячей планетой в Солнечной системе, несмотря на то, что Меркурий находится ближе к Солнцу. Венера покрыта непрозрачным слоем облаков из серной кислоты с высокой отражающей способностью, что закрывает поверхность планеты от прямой видимости. Высокая температура поверхности обусловлена действием парникового эффекта.Перейти к разделу «#Атмосфера»\r\n\r\nВ качестве одного из наиболее ярких объектов в небе Венера стала важным элементом в человеческой культуре.Перейти к разделу «#В культуре» Это первая планета, для которой в начале второго тысячелетия до нашей эры было зафиксировано движение по небу. Как ближайшая к Земле планета, Венера была главной целью для ранних межпланетных исследований. Это также первая планета, окрестности которой посетил земной космический аппарат («Маринер-2» в 1962 году), и на поверхность которой была совершена посадка («Венера-7» в 1970 году). Плотные облака Венеры делают невозможным наблюдение её поверхности в видимом свете, поэтому подробные карты её поверхности появились только после выхода в 1991 году на околовенерианскую орбиту космического аппарата «Магеллан», осуществившего радиолокационное исследование поверхности Венеры с высоким разрешением. Существуют проекты по реализации более сложных задач на поверхности Венеры, в том числе с использованием планетоходов, но им мешают тяжёлые условия на поверхности Венеры.";

        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Земля́ — третья по удалённости от Солнца планета Солнечной системы. Самая плотная, пятая по диаметру и массе среди всех планет Солнечной системы и крупнейшая среди планет земной группы, в которую входят также Меркурий, Венера и Марс. Единственное известное человеку в настоящее время тело во Вселенной, населённое живыми организмами.\r\n\r\nВ публицистике и научно-популярной литературе могут использоваться синонимические термины — мир, голубая планета[16][17][18], Терра (от лат. Terra).\r\n\r\nНаучные данные указывают на то, что Земля образовалась из солнечной туманности около 4,54 миллиарда лет назадПерейти к разделу «#История Земли»[19] и вскоре после этого обрела свой единственный естественный спутник — Луну. Жизнь, предположительно, появилась на Земле примерно 4,25 млрд лет назад[20], то есть вскоре после её возникновенияПерейти к разделу «#Возникновение жизни». С тех пор биосфера Земли значительно изменила атмосферу и прочие абиотические факторы, обусловив количественный рост аэробных организмов, а также формирование озонового слоя, который вместе с магнитным полем Земли ослабляет вредную для жизни солнечную радиацию[21], тем самым сохраняя условия существования жизни на Земле. Радиация, обусловленная самой земной корой, со времён её образования значительно снизилась благодаря постепенному распаду радионуклидов, содержавшихся в ней. Кора Земли разделена на несколько сегментов, или тектонических плит, которые движутся по поверхности со скоростями порядка нескольких сантиметров в год. Изучением состава, строения и закономерностей развития Земли занимается наука геология.";


        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Марс — четвёртая по удалённости от Солнца и седьмая по размеру планета Солнечной системы; масса планеты составляет 10,7 % массы Земли.Перейти к разделу «#Основные сведения» Названа в честь Марса — древнеримского бога войны, соответствующего древнегреческому Аресу.Перейти к разделу «#В античной мифологии» Также Марс называют красной планетой из-за красноватого оттенка поверхности, придаваемого ей минералом маггемитом — γ-оксидом железа(III).Перейти к разделу «#Грунт»\r\n\r\nМарс — планета земной группы с разреженной атмосферой (давление на поверхности в 160 раз меньше земного).Перейти к разделу «#Атмосфера и климат» Особенностями поверхностного рельефа Марса можно считать ударные кратеры наподобие лунных, а также вулканы, долины, пустыни и полярные ледниковые шапки наподобие земных.Перейти к разделу «#Лёд и полярные шапки»";


        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Юпи́тер — крупнейшая планета Солнечной системы, пятая по удалённости от Солнца. Наряду с Сатурном Юпитер классифицируется как газовый гигант.Перейти к разделу «#Юпитер среди планет Солнечной системы»\r\n\r\nПланета была известна людям с глубокой древности, что нашло своё отражение в мифологии и религиозных верованиях различных культур: месопотамской, вавилонской, греческой и других. Современное название Юпитера происходит от имени древнеримского верховного бога-громовержца.Перейти к разделу «#Название и история изучения»\r\n\r\nРяд атмосферных явлений на Юпитере — штормы,Перейти к разделу «#Движение атмосферы» молнии,Перейти к разделу «#Молнии» полярные сияния,Перейти к разделу «#Полярные сияния на Юпитере» — имеет масштабы, на порядки превосходящие земные. Примечательным образованием в атмосфере является Большое красное пятно — гигантский шторм, известный с XVII века.Перейти к разделу «#Большое красное пятно»\r\n\r\nЮпитер имеет, по крайней мере, 95 спутников[6], самые крупные из которых — Ио, Европа, Ганимед и Каллисто — были открыты Галилео Галилеем в 1610 году.Перейти к разделу «#Спутники и кольца»";


        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Сату́рн — шестая планета по удалённости от Солнца и вторая по размерам планета в Солнечной системе после Юпитера. Сатурн классифицируется как газовая планета-гигант. Сатурн назван в честь римского бога земледелия.Перейти к разделу «#Сатурн в культуре» Символ Сатурна — ♄.\r\n\r\nВ основном Сатурн состоит из водорода, с примесями гелия и следами воды, метана, аммиака и тяжёлых элементов. Внутренняя область представляет собой относительно небольшое ядро из железа, никеля и льда, покрытое тонким слоем металлического водорода и газообразным внешним слоем.Перейти к разделу «#Внутреннее строение» Внешняя атмосфера планеты кажется из космоса спокойной и однородной, хотя иногда на ней появляются долговременные образования. Скорость ветра на Сатурне может достигать местами 1800 км/ч, что значительно больше, чем на Юпитере.Перейти к разделу «#Атмосфера и строение» У Сатурна имеется планетарное магнитное поле, занимающее промежуточное положение по напряжённости между магнитным полем Земли и мощным полем Юпитера. Магнитное поле Сатурна простирается на 1 000 000 километров в направлении Солнца. Ударная волна была зафиксирована «Вояджером-1» на расстоянии в 26,2 радиуса Сатурна от самой планеты, магнитопауза расположена на расстоянии в 22,9 радиуса.Перейти к разделу «#Магнитное поле»";


        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Ура́н — планета Солнечной системы, седьмая по удалённости от Солнца, третья по диаметру и четвёртая по массе. Была открыта в 1781 году английским астрономом Уильямом Гершелем и названа в честь греческого бога неба Урана.\r\n\r\nУран стал первой планетой, обнаруженной в Новое время и при помощи телескопа[11]. Его открыл Уильям Гершель 13 марта 1781 года[12], тем самым впервые со времён античности расширив границы Солнечной системы в глазах человека. Несмотря на то, что порой Уран различим невооружённым глазом, более ранние наблюдатели принимали его за тусклую звезду[13].";


        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Непту́н — восьмая и самая дальняя от Солнца планета Солнечной системы. Его масса превышает массу Земли в 17,2 раза и является третьей среди планет Солнечной системы, а по экваториальному диаметру Нептун занимает четвёртое место, превосходя Землю в 3,9 раза[9]. Планета названа в честь Нептуна — римского бога морей[10].\r\n\r\nОбнаружен 23 сентября 1846 года[11], став первой планетой, открытой благодаря математическим расчётам[12]. Обнаружение непредсказуемых изменений орбиты Урана породило гипотезу о неизвестной планете, гравитационным возмущающим влиянием которой они и обусловлены. Нептун был найден в пределах предсказанной орбиты. Вскоре был открыт его крупнейший спутник Тритон, а в 1949 году — Нереида. Нептун посещался лишь одним космическим аппаратом, «Вояджером-2», который пролетел вблизи планеты 24—25 августа 1989 года. С его помощью были открыты кольца Нептуна и 6 его спутников[13]. Остальные известные спутники Нептуна открыты в XXI веке.";


        }

        private void ListBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            Info.Text += "Плуто́н (134340 Pluto, символы: \u2bd3 и ♇) — крупнейшая известная карликовая планета Солнечной системы[11], транснептуновый объект и десятое по массе (без учёта спутников) небесное тело, обращающееся вокруг Солнца — после восьми планет и Эриды[12][13][14]. Первоначально Плутон считали девятой классической планетой, но с 2006 года он считается карликовой планетой и крупнейшим объектом пояса Койпера.\r\n\r\nКак и большинство тел пояса Койпера, Плутон состоит в основном из камня и льда, и он относительно мал: его масса меньше массы Луны примерно в шесть раз, а объём — примерно в три раза. Площадь Плутона 17,7 млн км². У орбиты Плутона большой эксцентриситет и большой наклон к плоскости эклиптики.";


        }
    }
}
