using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurvForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private string mainContentProperty;
        private string numeroContentProperty;
        private string emailContentProperty;
        private string nacionContentProperty;
        private DateTime fechaContentProperty;
        private string nivelIngContentProperty;
        private string perfilContentProperty;

        public string MainContentProperty
        {
            get { return mainContentProperty; }
            set
            {
                mainContentProperty = value;
                OnPropertyChanged(nameof(MainContentProperty));
            }
        }
        public string perfilContProperty
        {
            get { return perfilContentProperty; }
            set
            {
                perfilContentProperty = value;
                OnPropertyChanged(nameof(perfilContProperty));
            }
        }
        public string nivelIngContProperty
        {
            get { return nivelIngContentProperty; }
            set
            {
                nivelIngContentProperty = value;
                OnPropertyChanged(nameof(nivelIngContProperty));
            }
        }
        public DateTime fechaContPro {
            get { return fechaContentProperty; }
            set
            {
                fechaContentProperty = value;
                OnPropertyChanged(nameof(fechaContPro));
            }
        }
        public string nacionContPro
        {
            get { return nacionContentProperty; }
            set
            {
                nacionContentProperty = value;
                OnPropertyChanged(nameof(nacionContPro));
            }
        }
        public string numeroContPro
        {
            get { return numeroContentProperty; }
            set
            {
                numeroContentProperty = value;
                OnPropertyChanged(nameof(numeroContPro));
            }
        }
        public string emailContPro
        {
            get { return emailContentProperty; }
            set
            {
                emailContentProperty = value;
                OnPropertyChanged(nameof(emailContPro));
            }
        }
        public MainPage(string mainContent, string numTelf,string nacion, DateTime fecha, string email,string nivel,string perfil)
        {
            InitializeComponent();
            BindingContext = this;
            MainContentProperty = mainContent;
            numeroContPro = numTelf;
            nacionContPro = nacion;
            fechaContPro = fecha;
            emailContPro = email;
            nivelIngContProperty = nivel;
            perfilContProperty = perfil;
        }
    }
}
