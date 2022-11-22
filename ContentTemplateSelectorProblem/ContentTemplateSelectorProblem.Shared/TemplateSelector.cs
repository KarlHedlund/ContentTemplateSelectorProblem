using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentTemplateSelectorProblem
{
    public class TemplateSelector : DataTemplateSelector
    {
        public TemplateSelector()
        {
            int x = 5;
            x++;
        }

        public DataTemplate ATemplate { get; set; }


        protected override DataTemplate SelectTemplateCore(object item) => SelectTemplateCore(item, null);

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return ATemplate;
        }
    }
}
