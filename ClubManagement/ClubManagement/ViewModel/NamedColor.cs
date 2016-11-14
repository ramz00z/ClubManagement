using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClubManagement.ViewModel
{
    public class NamedColor
    { // Instance members. 
        private NamedColor()
        {
        }
        public string Name { private set; get; }
        public string FriendlyName { private set; get; }
        public Color Color { private set; get; }
        public string RgbDisplay { private set; get; }
        // Static members. 
        static NamedColor()
        {
            List<NamedColor> all = new List<NamedColor>();
            StringBuilder stringBuilder = new StringBuilder();
            // Loop through the public static fields of type Color. 
            foreach (FieldInfo fieldInfo in typeof(NamedColor).GetRuntimeFields())
            {
                if (fieldInfo.IsPublic && fieldInfo.IsStatic && fieldInfo.FieldType == typeof(Color))
                {
                    // Convert the name to a friendly name.
                    string name = fieldInfo.Name; stringBuilder.Clear();
                    int index = 0; foreach (char ch in name)
                    {
                        if (index != 0 && Char.IsUpper(ch))
                        {
                            stringBuilder.Append(' ');
                        }
                        stringBuilder.Append(ch); index++;
                    }
                    // Instantiate
                    Color color = (Color)fieldInfo.GetValue(null);
                    NamedColor namedColor = new NamedColor
                    {
                        Name = name,
                        FriendlyName = stringBuilder.ToString(),
                        Color = color,
                        RgbDisplay = String.Format("{0:X2}-{1:X2}-{2:X2}", (int)(255 * color.R), (int)(255 * color.G), (int)(255 * color.B))
                    };
                    // Add it to the collection. 
                    all.Add(namedColor);
                }
            }
            all.TrimExcess();
            All = all;
        }

        //public override string ToString()
        //{
        //    return FriendlyName;
        //}

        public static IList<NamedColor> All { private set; get; }
        // Color names and definitions from http://www.w3.org/TR/css3-color/ 
        // (but with color names converted to camel case). 
        public static readonly Color Aliceblue = Color.FromRgb(240, 248, 255);
        public static readonly Color Antiquewhite = Color.FromRgb(250, 235, 215);
        public static readonly Color Aqua = Color.FromRgb(0, 255, 255);
        public static readonly Color Aquamarine = Color.FromRgb(127, 255, 212);
        public static readonly Color Azure = Color.FromRgb(240, 255, 255);
        public static readonly Color Beige = Color.FromRgb(245, 245, 220);
        public static readonly Color Bisque = Color.FromRgb(255, 228, 196);
        public static readonly Color Black = Color.FromRgb(0, 0, 0);
        public static readonly Color Blanchedalmond = Color.FromRgb(255, 235, 205);
        public static readonly Color Blue = Color.FromRgb(0, 0, 255);
        public static readonly Color Blueviolet = Color.FromRgb(138, 43, 226);
        public static readonly Color Brown = Color.FromRgb(165, 42, 42);
        public static readonly Color Burlywood = Color.FromRgb(222, 184, 135);
        public static readonly Color Cadetblue = Color.FromRgb(95, 158, 160);
        public static readonly Color Chartreuse = Color.FromRgb(127, 255, 0);
        public static readonly Color Chocolate = Color.FromRgb(210, 105, 30);
        public static readonly Color Coral = Color.FromRgb(255, 127, 80);
        public static readonly Color Cornflowerblue = Color.FromRgb(100, 149, 237);
        public static readonly Color Cornsilk = Color.FromRgb(255, 248, 220);
        public static readonly Color Crimson = Color.FromRgb(220, 20, 60);
        public static readonly Color Cyan = Color.FromRgb(0, 255, 255);
        public static readonly Color Darkblue = Color.FromRgb(0, 0, 139);
        public static readonly Color Darkcyan = Color.FromRgb(0, 139, 139);
        public static readonly Color Darkgoldenrod = Color.FromRgb(184, 134, 11);
        public static readonly Color Darkgray = Color.FromRgb(169, 169, 169);
        public static readonly Color Darkgreen = Color.FromRgb(0, 100, 0);
        public static readonly Color Darkgrey = Color.FromRgb(169, 169, 169);
        public static readonly Color Darkkhaki = Color.FromRgb(189, 183, 107);
        public static readonly Color Darkmagenta = Color.FromRgb(139, 0, 139);
        public static readonly Color Darkolivegreen = Color.FromRgb(85, 107, 47);
        public static readonly Color Darkorange = Color.FromRgb(255, 140, 0);
        public static readonly Color Darkorchid = Color.FromRgb(153, 50, 204);
        public static readonly Color Darkred = Color.FromRgb(139, 0, 0);
        public static readonly Color Darksalmon = Color.FromRgb(233, 150, 122);
        public static readonly Color Darkseagreen = Color.FromRgb(143, 188, 143);
        public static readonly Color Darkslateblue = Color.FromRgb(72, 61, 139);
        public static readonly Color Darkslategray = Color.FromRgb(47, 79, 79);
        public static readonly Color Darkslategrey = Color.FromRgb(47, 79, 79);
        public static readonly Color Darkturquoise = Color.FromRgb(0, 206, 209);
        public static readonly Color Darkviolet = Color.FromRgb(148, 0, 211);
        public static readonly Color Deeppink = Color.FromRgb(255, 20, 147);
        public static readonly Color Deepskyblue = Color.FromRgb(0, 191, 255);
        public static readonly Color Dimgray = Color.FromRgb(105, 105, 105);
        public static readonly Color Dimgrey = Color.FromRgb(105, 105, 105);
        public static readonly Color Dodgerblue = Color.FromRgb(30, 144, 255);
        public static readonly Color Firebrick = Color.FromRgb(178, 34, 34);
        public static readonly Color Floralwhite = Color.FromRgb(255, 250, 240);
        public static readonly Color Forestgreen = Color.FromRgb(34, 139, 34);
        public static readonly Color Fuchsia = Color.FromRgb(255, 0, 255);
        public static readonly Color Gainsboro = Color.FromRgb(220, 220, 220);
        public static readonly Color Ghostwhite = Color.FromRgb(248, 248, 255);
        public static readonly Color Gold = Color.FromRgb(255, 215, 0);
        public static readonly Color Goldenrod = Color.FromRgb(218, 165, 32);
        public static readonly Color Gray = Color.FromRgb(128, 128, 128);
        public static readonly Color Green = Color.FromRgb(0, 128, 0);
        public static readonly Color Greenyellow = Color.FromRgb(173, 255, 47);
        public static readonly Color Grey = Color.FromRgb(128, 128, 128);
        public static readonly Color Honeydew = Color.FromRgb(240, 255, 240);
        public static readonly Color Hotpink = Color.FromRgb(255, 105, 180);
        public static readonly Color Indianred = Color.FromRgb(205, 92, 92);
        public static readonly Color Indigo = Color.FromRgb(75, 0, 130);
        public static readonly Color Ivory = Color.FromRgb(255, 255, 240);
        public static readonly Color Khaki = Color.FromRgb(240, 230, 140);
        public static readonly Color Lavender = Color.FromRgb(230, 230, 250);
        public static readonly Color Lavenderblush = Color.FromRgb(255, 240, 245);
        public static readonly Color Lawngreen = Color.FromRgb(124, 252, 0);
        public static readonly Color Lemonchiffon = Color.FromRgb(255, 250, 205);
        public static readonly Color Lightblue = Color.FromRgb(173, 216, 230);
        public static readonly Color Lightcoral = Color.FromRgb(240, 128, 128);
        public static readonly Color Lightcyan = Color.FromRgb(224, 255, 255);
        public static readonly Color Lightgoldenrodyellow = Color.FromRgb(250, 250, 210);
        public static readonly Color Lightgray = Color.FromRgb(211, 211, 211);
        public static readonly Color Lightgreen = Color.FromRgb(144, 238, 144);
        public static readonly Color Lightgrey = Color.FromRgb(211, 211, 211);
        public static readonly Color Lightpink = Color.FromRgb(255, 182, 193);
        public static readonly Color Lightsalmon = Color.FromRgb(255, 160, 122);
        public static readonly Color Lightseagreen = Color.FromRgb(32, 178, 170);
        public static readonly Color Lightskyblue = Color.FromRgb(135, 206, 250);
        public static readonly Color Lightslategray = Color.FromRgb(119, 136, 153);
        public static readonly Color Lightslategrey = Color.FromRgb(119, 136, 153);
        public static readonly Color Lightsteelblue = Color.FromRgb(176, 196, 222);
        public static readonly Color Lightyellow = Color.FromRgb(255, 255, 224);
        public static readonly Color Lime = Color.FromRgb(0, 255, 0);
        public static readonly Color Limegreen = Color.FromRgb(50, 205, 50);
        public static readonly Color Linen = Color.FromRgb(250, 240, 230);
        public static readonly Color Magenta = Color.FromRgb(255, 0, 255);
        public static readonly Color Maroon = Color.FromRgb(128, 0, 0);
        public static readonly Color Mediumaquamarine = Color.FromRgb(102, 205, 170);
        public static readonly Color Mediumblue = Color.FromRgb(0, 0, 205);
        public static readonly Color Mediumorchid = Color.FromRgb(186, 85, 211);
        public static readonly Color Mediumpurple = Color.FromRgb(147, 112, 219);
        public static readonly Color Mediumseagreen = Color.FromRgb(60, 179, 113);
        public static readonly Color Mediumslateblue = Color.FromRgb(123, 104, 238);
        public static readonly Color Mediumspringgreen = Color.FromRgb(0, 250, 154);
        public static readonly Color Mediumturquoise = Color.FromRgb(72, 209, 204);
        public static readonly Color Mediumvioletred = Color.FromRgb(199, 21, 133);
        public static readonly Color Midnightblue = Color.FromRgb(25, 25, 112);
        public static readonly Color Mintcream = Color.FromRgb(245, 255, 250);
        public static readonly Color Mistyrose = Color.FromRgb(255, 228, 225);
        public static readonly Color Moccasin = Color.FromRgb(255, 228, 181);
        public static readonly Color Navajowhite = Color.FromRgb(255, 222, 173);
        public static readonly Color Navy = Color.FromRgb(0, 0, 128);
        public static readonly Color Oldlace = Color.FromRgb(253, 245, 230);
        public static readonly Color Olive = Color.FromRgb(128, 128, 0);
        public static readonly Color Olivedrab = Color.FromRgb(107, 142, 35);
        public static readonly Color Orange = Color.FromRgb(255, 165, 0);
        public static readonly Color Orangered = Color.FromRgb(255, 69, 0);
        public static readonly Color Orchid = Color.FromRgb(218, 112, 214);
        public static readonly Color Palegoldenrod = Color.FromRgb(238, 232, 170);
        public static readonly Color Palegreen = Color.FromRgb(152, 251, 152);
        public static readonly Color Paleturquoise = Color.FromRgb(175, 238, 238);
        public static readonly Color Palevioletred = Color.FromRgb(219, 112, 147);
        public static readonly Color Papayawhip = Color.FromRgb(255, 239, 213);
        public static readonly Color Peachpuff = Color.FromRgb(255, 218, 185);
        public static readonly Color Peru = Color.FromRgb(205, 133, 63);
        public static readonly Color Pink = Color.FromRgb(255, 192, 203);
        public static readonly Color Plum = Color.FromRgb(221, 160, 221);
        public static readonly Color Powderblue = Color.FromRgb(176, 224, 230);
        public static readonly Color Purple = Color.FromRgb(128, 0, 128);
        public static readonly Color Red = Color.FromRgb(255, 0, 0);
        public static readonly Color Rosybrown = Color.FromRgb(188, 143, 143);
        public static readonly Color Royalblue = Color.FromRgb(65, 105, 225);
        public static readonly Color Saddlebrown = Color.FromRgb(139, 69, 19);
        public static readonly Color Salmon = Color.FromRgb(250, 128, 114);
        public static readonly Color Sandybrown = Color.FromRgb(244, 164, 96);
        public static readonly Color Seagreen = Color.FromRgb(46, 139, 87);
        public static readonly Color Seashell = Color.FromRgb(255, 245, 238);
        public static readonly Color Sienna = Color.FromRgb(160, 82, 45);
        public static readonly Color Silver = Color.FromRgb(192, 192, 192);
        public static readonly Color Skyblue = Color.FromRgb(135, 206, 235);
        public static readonly Color Slateblue = Color.FromRgb(106, 90, 205);
        public static readonly Color Slategray = Color.FromRgb(112, 128, 144);
        public static readonly Color Slategrey = Color.FromRgb(112, 128, 144);
        public static readonly Color Snow = Color.FromRgb(255, 250, 250);
        public static readonly Color Springgreen = Color.FromRgb(0, 255, 127);
        public static readonly Color Steelblue = Color.FromRgb(70, 130, 180);
        public static readonly Color Tan = Color.FromRgb(210, 180, 140);
        public static readonly Color Teal = Color.FromRgb(0, 128, 128);
        public static readonly Color Thistle = Color.FromRgb(216, 191, 216);
        public static readonly Color Tomato = Color.FromRgb(255, 99, 71);
        public static readonly Color Turquoise = Color.FromRgb(64, 224, 208);
        public static readonly Color Violet = Color.FromRgb(238, 130, 238);
        public static readonly Color Wheat = Color.FromRgb(245, 222, 179);
        public static readonly Color White = Color.FromRgb(255, 255, 255);
        public static readonly Color Whitesmoke = Color.FromRgb(245, 245, 245);
        public static readonly Color Yellow = Color.FromRgb(255, 255, 0);
        public static readonly Color Yellowgreen = Color.FromRgb(154, 205, 50);
    }
}
