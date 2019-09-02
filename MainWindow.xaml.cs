using System;
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

namespace Letterfrequenties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox_Output.Text = CountLetters(TextBox_Input.Text);
            }
        }

        private string CountLetters(string input)
        {
            // Create a dictionary to count how many times each letter is in the text
            var letters = new Dictionary<char, int>();
            foreach (var e in characters)
                letters.Add(e.Value, 0);

            // Check all the characters in the text against the characters dictionary
            foreach (var c in input)
                foreach (var entry in characters)
                    if (entry.Key.Contains(c))
                        letters[entry.Value]++;

            // Convert the counting dictionary to something that's easily readable
            string output = "";
            foreach (var e in letters)
                if (e.Value > 0)
                    output += e.Key + " = " + e.Value.ToString() + "\n";
            return output;
        }

        static Dictionary<string, char> characters = new Dictionary<string, char>
        {
            { "AaÀÁÂÃÄÅǺĀĂĄǍΑΆẢẠẦẪẨẬẰẮẴẲẶАàáâãåǻāăąǎªαάảạầấẫẩậằắẵẳặаÄäæǽÆǼ", 'A' },
            { "BbБб", 'B' },
            { "CcÇĆĈĊČçćĉċčЧч", 'C' },
            { "DdДдÐĎĐΔðďđδ", 'D' },
            { "EeÈÉÊËĒĔĖĘĚΕΈẼẺẸỀẾỄỂỆЕЭèéêëēĕėęěέεẽẻẹềếễểệеэέἐὲ", 'E' },
            { "FfФфƒ", 'F' },
            { "GgĜĞĠĢΓГҐĝğġģγгґΧ", 'G' },
            { "HhĤĦĥħ", 'H' },
            { "IiÌÍÎÏĨĪĬǏĮİΗΉΊΙΪỈỊИЫìíîïĩīĭǐįıηήἥίιϊỉịиыї", 'I' },
            { "JjĴĵ", 'J' },
            { "KkĶΚКķκкξХх", 'K' },
            { "LlĹĻĽĿŁΛЛĺļľŀłλл", 'L' },
            { "MmМмμ", 'M' },
            { "NnÑŃŅŇΝНñńņňŉνнν", 'N' },
            { "OoÒÓÔÕŌŎǑŐƠØǾΟΌΩΏỎỌỒỐỖỔỘỜỚỠỞỢОÖöœòóôõōŏǒőơøǿºοόωώỏọồốỗổộờớỡởợоŒὸὸ", 'O' },
            { "PpПпπψ", 'P' },
            { "Qq", 'Q' },
            { "RrŔŖŘΡРŕŗřρр", 'R' },
            { "SsŚŜŞȘŠΣСśŝşșšſσςсßШшЩщ", 'S' },
            { "TtȚŢŤŦτТțţťŧтЦцθ", 'T' },
            { "UuÙÚÛŨŪŬŮŰŲƯǓǕǗǙǛŨỦỤỪỨỮỬỰУÜüùúûũūŭůűųưǔǖǘǚǜυύϋủụừứữửựу", 'U' },
            { "VvВвβ", 'V' },
            { "WwŴŵ", 'W' },
            { "Xx", 'X' },
            { "YyÝŸŶΥΎΫỲỸỶỴЙýÿŷỳỹỷỵйĲĳЁёЄєЇЮюЯя", 'Y' },
            { "ZzŹŻŽΖЗźżžζзЖж", 'Z' },
        };
    }
}
