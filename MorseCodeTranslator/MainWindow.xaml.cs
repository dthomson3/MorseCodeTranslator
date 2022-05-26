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
using System.Diagnostics;

namespace MorseCodeTranslator;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Stopwatch _stopwatch = new();
    public long dotLength = 200;
    public long dashLength = 500;
    public long newLetterLength = 1000;

    public string letter = string.Empty;
    public string word = string.Empty;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainText_MouseDown(object sender, MouseButtonEventArgs e)
    {
        HeldText.Text = "held";
        _stopwatch.Reset();
        _stopwatch.Start();
    }

    private void MainText_MouseUp(object sender, MouseButtonEventArgs e)
    {
        HeldText.Text = "released";
        _stopwatch.Stop();
        long time = _stopwatch.ElapsedMilliseconds;
        if (time < dotLength)
        {
            letter += ".";
            word += ".";
        }
        else if (time < dashLength)
        {
            letter += "-";
            word += "-";
        }
        else if (time <= newLetterLength)
        {
            ParseWord();
        }
        else if (time > newLetterLength)
        {
            word += " ";
        }
        MainText.Text = word;
    }

    private void ParseWord()
    {
        
        if (MorseCodeDictionary.dictionary.ContainsKey(letter))
        {
            if (letter.Length == 1)
            {
                word = word.Remove(word.Length - 1);
            }
            else
            {
                word = word.Remove(word.Length - letter.Length);
            }
            word += MorseCodeDictionary.dictionary[letter];
            letter = string.Empty;
        }

    }

    private void MaxDotTime_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {

    }

    private void MaxDotTime_TargetUpdated(object sender, DataTransferEventArgs e)
    {

    }
}
