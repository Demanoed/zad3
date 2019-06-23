using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemanT_Library;

namespace PopalNePopal
{
    class Program
    {
        private static int x, y;
        private static void ZaprosXY()
        {
            ColorMess.Yellow("\n Введите координату точки X: ");
            x = Input.Check(int.MinValue, int.MaxValue);
            ColorMess.Yellow("\n Введите координату точки Y: ");
            y = Input.Check(int.MinValue, int.MaxValue);
        }
        private static bool ChekPopadanie()
        {
            bool ploskost1 = (x <= 0 && y <= 0 && y >= -1 && y <= (3 * x + 2));
            bool ploskost2 = (x >= 0 && y <= 0 && y >= -1 && y <= (-3 * x + 2));
            bool ploskost3 = (x >= 0 && y >= 0 && y <= (-3 * x + 2));
            bool ploskost4 = (x <= 0 && y >= 0 && y <= (3 * x + 2));
            if (ploskost1 || ploskost2 || ploskost3 || ploskost4) return true;
            else return false;
        }
        private static void PrintResult(bool ok)
        {
            if (ok)
                ColorMess.Green("\n Точка попала в область");
            else
                ColorMess.Red("\n Точка не попала в область");
        }
        static void Main()
        {
            ZaprosXY();
            PrintResult(ChekPopadanie());
            Message.GoToBack();
        }
    }
}
