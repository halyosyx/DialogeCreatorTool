using System;
using System.Collections.Generic;
using System.IO;
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

namespace DialogueCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
         string _path = "C:\\charaDialogue.json";

        List<CharacterDialogue> dialogue = new List<CharacterDialogue>();
        SaveAndLoadJson saveAndLoad = new SaveAndLoadJson();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            CharacterDialogue dialogues = new CharacterDialogue(1, "David", "asda.png", "hello my name david");
            dialogue.Add(dialogues);
            saveAndLoad.SaveJsonFile(_path, dialogue);
        }
    }
}
