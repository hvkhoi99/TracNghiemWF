using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI_Tier
{
    public class ThemSuaXoa
    {
        /// <summary>
        /// Thí Sinh
        /// </summary>
        /// <returns></returns>
        public string ThemSuaXoa_ThiSinh(string HanhDong, string NoiDung)
        {
            switch (HanhDong)
            {
                case "Thêm":
                    return "Thí Sinh-" + HanhDong + "-" + NoiDung;
                default:
                    return "";
                
            }
        }
    }
}
