using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int BO = 0;
            int GR = 0;
            int count = 0;
            int countG = 0;
            int SUN = 0;
            int countA = 0;
            int countB = 0;
            int countO = 0;
            int countAB = 0;
            int countC = 0;
            int CountC=0;
            
            int[] Long = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] Name={"葉俊廷","張澤瑜","王程捷 的咩？","江儀婷","張秉華","陳柏霖","黃紀瑜","黃昱維","蔡逸群","登琳","世新魏鈞孝吧","劉定南","陳信如","童信傑","李岳倫","鄒和恆","簡毓玟","劉子瑄","蕭紹洋","李亞宸la","張以潔","邱仕紳","呂家瑩","世新林鑫佑","徐均得","陳佳欣","張恩瑋","周詮","王湘婷","蕭宇成","Max Cheung(BANG)","馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000","陳昱嘉","康珈熏","盧奕宏","陳郁佳的大哥黃博涵","遲正雯","世新林星彤","許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　","許子安","高子晴","陳思婷","矝鵘鮿","余彥廷","吳耀輝","鄭丞智","林冠廷","世新何曜宇","邵喬雨","張豐愷","林子晴","邱雁回","陳家欣是韓妞","鄧雅馨","謝汶珊","李曼寧","我是陳柏霖2號","张钰慈","鍾宜珊","raer_tsai","世新李姳諼","鄭曼君","陳柏霖","世新許子安","世新方若帆","李曼寧","世新遲正雯","世新周詮"};
            string[] FFF = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            for (int C = 0; C < name.Length;C++ )
            {
                if (name[C] == "女")
                {
                    countC++;
                }
            if(name[C]=="男")
            {
                CountC++;
            }
            }
            double GIRL = (double)countC / (double)name.Length * 100;
            double BOY = (double)CountC / (double)name.Length * 100;
            Console.WriteLine("女生人數百分比", countC, GIRL);
            Console.WriteLine("男生人數百分比", CountC, BOY);

                for (int b = 0; b < blood.Length; b++)
                {
                    if (blood[b] == "A")
                    {
                        countA++;
                    }
                    if (blood[b] == "B")
                    {
                        countB++;
                    }
                    if (blood[b] == "O")
                    {
                        countO++;
                    }
                    if (blood[b] == "AB")
                    {
                        countAB++;
                    }
                }
            double precentA = (double)countA / (double)blood.Length * 100;
            double precentB = (double)countB / (double)blood.Length * 100;
            double precentO = (double)countO / (double)blood.Length * 100;
            double precentAB = (double)countAB / (double)blood.Length * 100;
            Console.WriteLine("A型人數: {0} {1:0} %", countA, precentA);
            Console.WriteLine("B型人數: {0} {1:0} %", countB, precentB);
            Console.WriteLine("O型人數: {0} {1:0} %", countO, precentO);
            Console.WriteLine("AB型人數: {0} {1:0} %", countAB, precentAB);
            for (int i = 0; i < Long.Length; i++)
            {
                if (Long[i] > 100 && Long[i] < 200)
                {
                    if (name[i] == "女")
                    {
                        BO = BO + Long[i];
                        count++;
                    }
                    else if (Long[i] > 100 && Long[i] < 200)
                    {
                        if (name[i] == "男")
                        {
                            GR = GR + Long[i];
                            countG++;
                        }
                    }

                }


            }
            for (int A = 0; A < Long.Length; A++)
            {
                if (Long[A] > 100 && Long[A] < 200)
                    if (name[A] == "男" || name[A] == "女")
                    {
                        SUN = SUN + Long[A];
                    }
            }
            // double pBoy = countBoy / name.Length * 100;
            Console.WriteLine("女生平均身高" + BO / count + "公分");
            Console.WriteLine("男生頻均身高" + GR / countG + "公分");
            Console.WriteLine("全班平均身高" + SUN / name.Length + "公分");

            
            for(int F=0;F<FFF.Length;F++){
                if(blood[F]=="O"&&FFF[F]=="天蠍")
                {
                    Console.WriteLine("既是天蠍座又是O型的人是"+Name[F]);
                }
            }
                Console.ReadLine(); 
            }
        }
    }

