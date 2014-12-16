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
using System.Windows.Shapes;
using Xenon.Common;
using Xenon.Data;
using Xenon.Server;

namespace Xenon.Wpf.Client
{
    /// <summary>
    /// Interaction logic for XenonShell.xaml
    /// </summary>
    public partial class XenonShell : Window
    {
        public XenonShell()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (QuestionnaireRepositoryManager manager = new QuestionnaireRepositoryManager())
            {
                Questionnaire auestionnaire = new Questionnaire() { Title = "OMG First!!111!" };
                Question question1 = new Question() { Text = "WTF?" };
                Question question2 = new Question() { Text = "OMG" };
                Tag tag = new Tag() { Text = "Junior Developer" };
                question1.Tags.Add(tag);
                question1.Tags.Add(new Tag() { Text = "Senior Developer" });
                question1.Difficulty = DifficultyLevel.Level4;
                question2.Tags.Add(tag);
                //question.Difficulty = new Difficulty() { Level = DiffucultyLevel.Level1 };
                auestionnaire.Questions.Add(question1);
                auestionnaire.Questions.Add(question2);
                manager.QuestionnaireRepository.Add(auestionnaire);
                manager.SaveChanges();
            }

            using (QuestionnaireRepositoryManager manager = new QuestionnaireRepositoryManager())
            {
                var a = manager.QuestionnaireRepository.GetAll().ToList();
                var n = a[0].Questions;
            }
        }
    }
}
