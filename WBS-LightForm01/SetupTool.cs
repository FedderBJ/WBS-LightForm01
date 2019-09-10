using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS_LightForm01
{
    using System.Drawing;
    using WSService;

    class SetupTool
    {
        private void GenerateColorCodes()
        {
            var service = new BalanceFunctions();
            service.UseDefaultCredentials = true;

            foreach (var colorValue in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor((KnownColor)colorValue);
                service.CreateCololerCodes(color.Name, color.Name);
            }
        }

        private void GenerateFontNames()
        {
            var service = new BalanceFunctions();
            service.UseDefaultCredentials = true;

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                service.CreateFontCodes(font.Name, font.Name);
            }
        }
        
        public Color ColorFromName(string colorName)
        {
            System.Drawing.Color systemColor = System.Drawing.Color.FromName(colorName);
            return systemColor;
        }

    }
}
