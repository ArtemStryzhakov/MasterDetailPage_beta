using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuItems
    {
        public string Text { get; set; }
        public string Detail { get; set; }
        public string Imagepath { get; set; }
        public Type Targetpage { get; set; }

    }
}