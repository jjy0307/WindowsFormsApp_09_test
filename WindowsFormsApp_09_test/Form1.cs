using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_09_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 업캐스팅
            Animal dog = new Dog();
            Animal bird = new Bird();
            Animal cat = new Cat();

            dog.Name = "강아지";
            cat.Name = "고양이";
            bird.Name = "새";

            // 업캐스팅
            dog.Speak();
            cat.Speak();
            bird.Speak();

            //다운캐스팅
            ((Dog)dog).DogSpeak();
            ((Cat)cat).CatSpeak();
            ((Bird)bird).BirdSpeak();
        }
    }
}
