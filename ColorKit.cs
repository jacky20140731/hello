using UnityEngine;

namespace com.haofa.common.kit
{
	/**
	 * 类说明：颜色
	 * 
	 * @version 1.0
	 */
    public class ColorKit
    {
        /// <summary> 黑色 </summary>
        public static Color Color_000000 = getColor(0x00, 0x00, 0x00);
        /// <summary> 好友推送（绿色） </summary>
        public static Color Color_1efe00 = getColor(0x1e, 0xfe, 0x00);
        public static Color Color_1f1f1f = getColor(0x1f, 0x1f, 0x1f);
        public static Color Color_331705 = getColor(0x33, 0x17, 0x05);
        public static Color Color_33ff66 = getColor(0x33, 0xff, 0x66);
        public static Color Color_3a0101 = getColor(0x3a, 0x01, 0x01);
        public static Color Color_3c0103 = getColor(0x3c, 0x01, 0x03);
        public static Color Color_3c2f27 = getColor(0x3c, 0x2f, 0x27);
        public static Color Color_4c3b30 = getColor(0x4c, 0x3b, 0x30);
        public static Color Color_57f400 = getColor(0x57, 0xf4, 0x00);
        public static Color Color_5ae13f = getColor(0x5a, 0xe1, 0x3f);
        public static Color Color_5ae140 = getColor(0x5a, 0xe1, 0x40);
        public static Color Color_624c35 = getColor(0x62, 0x4c, 0x35);
        public static Color Color_63ff4e = getColor(0x63, 0xff, 0x4e);
        public static Color Color_66ff00 = getColor(0x66, 0xff, 0x00);
        /// <summary> 灰（切换帐号） </summary>
        public static Color Color_685a46 = getColor(0x68, 0x5a, 0x46);
        public static Color Color_7fa0ff = getColor(0x7f, 0xa0, 0xff);
        public static Color Color_856037 = getColor(0x85, 0x60, 0x37);
        public static Color Color_ded8c2 = getColor(0xde, 0xd8, 0xc2);
        public static Color Color_fffae3 = getColor(0xff, 0xfa, 0xe3);
        public static Color Color_fffae4 = getColor(0xff, 0xfa, 0xe4);
        public static Color Color_f6ecd2 = getColor(0xf6, 0xec, 0xd2);
        /// <summary> 灰白（注册信息字体） </summary>
        public static Color Color_8f979e = getColor(0x8f, 0x97, 0x9e);
        public static Color Color_9598a2 = getColor(0x95, 0x98, 0xa2);
        public static Color Color_faefd1 = getColor(0xfa, 0xef, 0xd1);
        public static Color Color_fdf9e5 = getColor(0xfd, 0xf9, 0xe5);
        public static Color Color_c7d6f4 = getColor(0xc7, 0xd6, 0xf4);
        /// <summary> 红色（注册信息错误提示） </summary>
        public static Color Color_9c0000 = getColor(0x9c, 0x00, 0x00);
        public static Color Color_a4650a = getColor(0xa4, 0x65, 0x0a);
        public static Color Color_bd9c55 = getColor(0xbd, 0x9c, 0x55);
        public static Color Color_bd9c57 = getColor(0xbd, 0x9c, 0x57);
        public static Color Color_be9d58 = getColor(0xbe, 0x9d, 0x58);
        public static Color Color_c2823b = getColor(0xc2, 0x82, 0x3b);
        public static Color Color_c67bff = getColor(0xc6, 0x7b, 0xff);
        public static Color Color_cba071 = getColor(0xcb, 0xa0, 0x71);
        public static Color Color_cdab85 = getColor(0xcd, 0xab, 0x85);
        public static Color Color_d6b089 = getColor(0xd6, 0xb0, 0x89);
        public static Color Color_d7b188 = getColor(0xd7, 0xb1, 0x88);
        public static Color Color_d7b590 = getColor(0xd7, 0xb5, 0x90);
        public static Color Color_e2c4a4 = getColor(0xe2, 0xc4, 0xa4);
        public static Color Color_e9b74a = getColor(0xe9, 0xb7, 0x4a);
        public static Color Color_eabd22 = getColor(0xea, 0xbd, 0x22);
        public static Color Color_eabd23 = getColor(0xea, 0xbd, 0x23);
        public static Color Color_f02a2b = getColor(0xf0, 0x2a, 0x2b);
        public static Color Color_f6a6ff = getColor(0xf6, 0xa6, 0xff);
        public static Color Color_f7d0a8 = getColor(0xf7, 0xd0, 0xa8);
        public static Color Color_f8df56 = getColor(0xf8, 0xdf, 0x56);
        public static Color Color_f8df57 = getColor(0xf8, 0xdf, 0x57);
        public static Color Color_fad86b = getColor(0xfa, 0xd8, 0x6b);
        public static Color Color_ff0000 = getColor(0xff, 0x00, 0x00);
        public static Color Color_ff5400 = getColor(0xff, 0x54, 0x00);
        public static Color Color_b22803 = getColor(0xb2, 0x28, 0x03);
        /// <summary> 类似红色（设置界面切换帐号错误消息） </summary>
        public static Color Color_cc2b00 = getColor(0xcc, 0x2b, 0x00);
        public static Color Color_ff6262 = getColor(0xff, 0x62, 0x62);
        public static Color Color_ffaf00 = getColor(0xff, 0xaf, 0x00);
        public static Color Color_ffae00 = getColor(0xff, 0xae, 0x00);
        public static Color Color_ffc851 = getColor(0xff, 0xc8, 0x51);
        public static Color Color_ffd200 = getColor(0xff, 0xd2, 0x00);
        public static Color Color_ffe11b = getColor(0xff, 0xe1, 0x1b);
        public static Color Color_ffe390 = getColor(0xff, 0xe3, 0x90);
        public static Color Color_fff04d = getColor(0xff, 0xf0, 0x4d);
        public static Color Color_fff2b6 = getColor(0xff, 0xf2, 0xb6);
        public static Color Color_ff2d00 = getColor(0xff, 0x2d, 0x00);
        /// <summary> 白色 </summary>
        public static Color Color_ffffff = getColor(0xff, 0xff, 0xff);
        public static Color Color_ffedd2 = getColor(0xff, 0xed, 0xd2);
        ///<summary> 土豪金 </summary>
        public static Color Color_ffba38 = getColor(0xff, 0xba, 0x38);
        public static Color Color_ffcb3e = getColor(0xff, 0xcb, 0x3e);
        public static Color Color_ffd013 = getColor(0xff, 0xd0, 0x13);
        ///<summary> 紫色 </summary>
        public static Color Color_a751ff = getColor(0xa7, 0x51, 0xff);
        public static Color Color_790dff = getColor(0x79, 0x0d, 0xff);
        ///<summary> 土黄 </summary>
        public static Color Color_f67f00 = getColor(0xf6, 0x7f, 0x00);
        public static Color Color_904d21 = getColor(0x90, 0x4d, 0x21);
        ///<summary> 泥巴色 </summary>
        public static Color Color_882401 = getColor(0x88, 0x24, 0x01);
        public static Color Color_ffb304 = getColor(0xff, 0xb3, 0x04);
        public static Color Color_cc9a3e = getColor(0xcc, 0x9a, 0x3e);
        ///<summary> 淡黄 </summary>
        public static Color Color_fffe8e = getColor(0xff, 0xfe, 0x8e);
        public static Color Color_ffa61a = getColor(0xff, 0xa6, 0x1a);
        public static Color Color_ffdf2b = getColor(0xff, 0xdf, 0x2b);
        public static Color Color_fffeb1 = getColor(0xff, 0xfe, 0xb1);
        public static Color Color_fff839 = getColor(0xff, 0xf8, 0x39);
        public static Color Color_5efff9 = getColor(0x5e, 0xff, 0xf9);
        public static Color Color_852119 = getColor(0x85, 0x21, 0x19);
        public static Color Color_ffff00 = getColor(0xff, 0xff, 0x00);
        public static Color Color_6f4209 = getColor(0x6f, 0x42, 0x09);
        public static Color Color_56fdff = getColor(0x56, 0xdf, 0xff);
        public static Color Color_ff9e2b = getColor(0xff, 0x9e, 0x2b);
        public static Color Color_f61919 = getColor(0xf6, 0x19, 0x19);
        public static Color Color_3a2b0a = getColor(0x3a, 0x2b, 0x0a);
        public static Color Color_fff178 = getColor(0xff, 0xf1, 0x78);
        public static Color Color_96744c = getColor(0x96, 0x74, 0x4c);
        public static Color Color_fff66c = getColor(0xff, 0xf6, 0x6c);
        public static Color Color_ff816c = getColor(0xff, 0x81, 0x6c);
        public static Color Color_eac30f = getColor(0xea, 0xc3, 0x0f);
        public static Color Color_0fead8 = getColor(0x0f, 0xea, 0xd8);
        public static Color Color_14ea0f = getColor(0x14, 0xea, 0x0f);
        public static Color Color_ff2b2b = getColor(0xff, 0x2b, 0x2b);
        public static Color Color_00ff24 = getColor(0x00, 0xff, 0x24);

        public static Color Color_b42a0b = getColor(0xb4, 0x2a, 0x0b);
        public static Color Color_ffea00 = getColor(0xff, 0xea, 0x00);
        public static Color Color_ffde90 = getColor(0xff, 0xde, 0x90);
        public static Color Color_55362b = getColor(0x55, 0x36, 0x2b);
        public static Color Color_6c0202 = getColor(0x6c, 0x02, 0x02);
        public static Color Color_ffe6a4 = getColor(0xff, 0xe6, 0xa4);
        ///<summary> 洋红 </summary>
        public static Color Color_be1ad1 = getColor(0xbe,0x1a,0xd1);
        public static Color Color_c13021 = getColor(0xc1, 0x30, 0x21);
        public static Color Color_ee42e8 = getColor(0xee, 0x42, 0xe8);
        ///<summary> 金黄 </summary>
        public static Color Color_efae00 = getColor(0xef, 0xae, 0x00);
        public static Color Color_ffd121 = getColor(0xff, 0xd1, 0x21);
        ///<summary> 绿宝石 </summary>
        public static Color Color_00bec0 = getColor(0x00, 0xbe, 0xc0);
        public static Color Color_fff09a = getColor(0xff, 0xf0, 0x9a);

        public static Color Color_ffe35e = getColor(0xff, 0xe3, 0x5e);
        public static Color Color_972f0b = getColor(0x97, 0x2f, 0x0b);
        ///<summary> 蓝色 </summary>
        public static Color Color_3b79df = getColor(0x3b, 0x79, 0xdf);
        public static Color Color_b79966 = getColor(0xb7, 0x99, 0x66);

        public static Color Color_d9d919 = getColor(0xd9, 0xd9, 0x19);
        public static Color Color_f6e6ce = getColor(0xf6, 0xe6, 0xce);

        public static Color Color_334b36 = getColor(0x33, 0x4b, 0x36);
        /// 颜色
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns></returns>
        public static Color getColor(int red, int green, int blue)
        {
            return getColor(red, green, blue, 1);
        }
        /// <summary>
        /// 带透明度的颜色
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static Color getColor(int red, int green, int blue, float alpha)
        {
            return new Color(red / 255f, green / 255f, blue / 255f, alpha);
        }
    }
}