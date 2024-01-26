using System;
namespace MyNamespace
{
	class MyClass
	{
		static void Main(string[] args)
		{
            #region Goi ham: Sap xep cac ky tu trong 1 chuoi tu be den lon
            //Sap xep cac ky tu trong 1 chuoi tu be den lon
            //Console.WriteLine("----Sap xep mot chuoi----");
            //Console.Write("Moi nhap chuoi can sap xep: ");
            //string s = Console.ReadLine();
            //Xep(ref s);
            //Console.WriteLine(s);
            #endregion

            #region Goi ham: Sap xep mang so nguyen duong tu be den lon
            //Sap xep mang so nguyen duong tu be den lon
            //         Console.WriteLine("----Sap xep mang nguyen----");
            //int[] arr;
            //NhapMangNguyen(out arr);
            //SapXepMangNguyen(ref arr);
            //XuatMangNguyen(arr);
            #endregion

            #region Goi ham: Nhap mang 2 chieu, tinh tong, tim cac ptu Boi 5, Dao 2 dong bat ki
            Console.WriteLine("----Mang Hai Chieu----");
            int[,] arrMatrix;
			NhapMangHaiChieu(out arrMatrix);
			Console.WriteLine("\nMa tran vua nhap: ");
			XuatMangHaiChieu(arrMatrix);
			Console.WriteLine("\n");
			SumArrayMatrix(arrMatrix);
			MultiplesOf5(arrMatrix);
			Console.WriteLine("---Hoan vi hai dong---");
			ColumnPermutation(ref arrMatrix);

            #endregion
        }

        #region Source Code Sap xep cac ky tu trong 1 chuoi tu be den lon
        //----------Source Code Sap xep cac ky tu trong 1 chuoi tu be den lon-------------------------------------------------------

        static void Xep(ref string s)
		{
			//chuyển đổi chuỗi S thành một mảng kí tự
			char[] newS = s.ToCharArray();
			for (int i = 0; i < newS.Length; i++)
			{
				for (int j = i + 1; j < newS.Length; j++)
				{
					if (newS[i] > newS[j])
					{
						char temp = newS[i];
						newS[i] = newS[j];
						newS[j] = temp;
					}
				}
			}
			//Tạo một đối tượng chuỗi mới từ các ký tự trong mảng charArray
			//Ở đây là gán mảng kí tự s lại thành một chuỗi s
			s = new string(newS);
		}
        #endregion

        #region Source Code Sap xep mang so nguyen tu be den lon
        //-------------------------Source Code Sap xep mang so nguyen tu be den lon-----------------------------------------------------------
        static void NhapMangNguyen(out int[] arr) {
            Console.WriteLine("Moi nhap so luong phan tu cho mang nguyen: ");
            int n;
            string valueInput = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(valueInput, out n) == false)
                {
                    Console.WriteLine("Nhap sai!!!");
                    Console.Write("Moi nhap lai so luong phan tu cho mang nguyen: ");
                    valueInput = Console.ReadLine();
                }
                else
                {
                    if (n > 0)
                    {
                        arr = new int[n];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nhap sai!!!(So luong phan tu phai la so nguyen duong)");
                        Console.Write("Moi nhap lai so luong phan tu cho mang nguyen: ");
                        valueInput = Console.ReadLine();
                    }
                }
            }


            for (int i = 0;i < arr.Length;i++)
			{
                Console.WriteLine($"Nhap phan tu arr[{i}]: ");
				string valueLocal = Console.ReadLine();

				while (true)
				{
					if (int.TryParse(valueLocal, out arr[i]) == false)
					{
						Console.WriteLine("Nhap sai!!!(So luong phan tu phai la so nguyen duong)");
						Console.Write($"Moi nhap lai phan tu arr[{i}]: ");
						valueLocal = Console.ReadLine();
                    }
					else
					{
						if (arr[i] < 0)
						{
                            Console.WriteLine("Nhap sai!!!(Phan tu phai la so nguyen duong)");
                            Console.Write($"Moi nhap lai phan tu arr[{i}]: ");
                            valueLocal = Console.ReadLine();
                        }
						else
							break;

					}
				}
			}
        }

		static void XuatMangNguyen(int[] arr)
		{
            Console.Write("Mang 1 chieu gom cac phan tu: ");
            for (int i = 0; i<arr.Length ; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}

		static void SapXepMangNguyen(ref int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i+1; j < arr.Length; j++)
				{
					if (arr[i] > arr[j])
					{
						int temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}
		}
        #endregion


        #region Source Code Nhap mang 2 chieu so nguyen, tinh tong, tim cac ptu Boi 5, Dao 2 dong bat ki 
		static void NhapMangHaiChieu(out int[,] arrayMatrix)
		{
			Console.Write("Nhap so dong cho Ma Tran: ");
			string tempRow = Console.ReadLine();
            Console.Write("Nhap so cot cho Ma Tran: ");
            string tempColumn = Console.ReadLine();
			int Row, Column;
			while(true)
			{
				if(int.TryParse(tempRow, out Row) == false || int.TryParse(tempColumn, out Column) == false)
				{
                    Console.WriteLine("Nhap sai!!!(So dong va cot phai la so nguyen duong)");
                    Console.Write("Nhap lai so dong cho Ma Tran: ");
                    tempRow = Console.ReadLine();
                    Console.Write("Nhap lai so cot cho Ma Tran: ");
                    tempColumn = Console.ReadLine();
                }
				else
				{
					if (Row < 0 || Column < 0)
					{
                        Console.WriteLine("Nhap sai!!!(So dong va cot phai la so nguyen duong)");
                        Console.Write("Nhap lai so dong cho Ma Tran: ");
                        tempRow = Console.ReadLine();
                        Console.Write("Nhap lai so cot cho Ma Tran: ");
                        tempColumn = Console.ReadLine();
                        
                    }
					else
					{
						arrayMatrix = new int[Row, Column];
						break;
					}
                }
			}

			for (int i = 0; i < arrayMatrix.GetLength(0); i++)
			{
				for(int j = 0; j < arrayMatrix.GetLength(1); j++)
				{
                    Console.Write($"Nhap phan tu arrayMatrix[{i},{j}]: ");
					string valueInput = Console.ReadLine();
					while (true)
					{
						if(int.TryParse(valueInput, out arrayMatrix[i,j]) == false)
						{
                            Console.WriteLine("Nhap sai!!!(So dong va cot phai la so nguyen duong)");
                            Console.Write($"Nhap lai phan tu arrayMatrix[{i},{j}]: ");
                            valueInput = Console.ReadLine();
                        }
						else
						{
							if (arrayMatrix[i,j] < 0)
							{
                                Console.WriteLine("Nhap sai!!!(Day la ma tran so nguyen)");
                                Console.Write($"Nhap lai phan tu arrayMatrix[{i},{j}]: ");
                                valueInput = Console.ReadLine();
                            }
							else
							{
								break;
							}
						}
					}
                }
			}
        }

		//Tinh tong cac phan tu trong ma tran
		static int SumArrayMatrix(int[,] arrMatrix)
		{
			int sumValue = 0;
			for( int i = 0;i < arrMatrix.GetLength(0); i++)
			{
				for(int j = 0;j < arrMatrix.GetLength(1); j++)
				{
					sumValue += arrMatrix[i, j];
				}
			}
			return sumValue;
		}

		//Tìm các phần tử bội của 5 sau đó in ra vị trí và giá trị

		static void MultiplesOf5(int[,] arrMatrix)
		{
            Console.WriteLine("Cac phan tu la boi cua 5: ");
            int count = 0;
            for (int i = 0; i < arrMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrMatrix.GetLength(1); j++)
                {
					if (arrMatrix[i,j] % 5 == 0)
					{
						count++;
                        //Console.WriteLine($"Có {count} phan tu la boi cua 5.");
						Console.WriteLine($"Phan tu {arrMatrix[i,j]} o vi tri: Dong {i}, Cot {j} ");
                    }
                }
            }
        }

		//Hoán vị hai dòng
		static void ColumnPermutation(ref int[,] arrMatrix)
		{
			string tempColumn1,tempColumn2;
			int Column1, Column2;
			Console.Write("Moi nhap dong thu nhat: ");
			tempColumn1 = Console.ReadLine();
            Console.Write("Moi nhap dong thu hai: ");
			tempColumn2 = Console.ReadLine();
			while (true)
			{
				if(int.TryParse(tempColumn1, out Column1) == false || int.TryParse(tempColumn2, out Column2) == false)
				{
                    Console.WriteLine("Nhap sai!!!(Chi so dong phai la so nguyen duong)");
                    Console.Write("Moi nhap lai dong thu nhat: ");
                    tempColumn1 = Console.ReadLine();
                    Console.WriteLine("Nhap sai!!!(Chi so dong phai la so nguyen duong)");
                    Console.Write("Moi nhap lai dong thu hai: ");
                    tempColumn2 = Console.ReadLine();
                }
				else if(Column1 < 0 || Column1 > arrMatrix.GetLength(0) || Column2 < 0 || Column2 > arrMatrix.GetLength(1))
				{
                    Console.WriteLine("Nhap sai!!!(Chi so dong ban nhap lon hon so dong ma tran va phai la so nguyen duong)");
                    Console.Write("Moi nhap lai dong thu nhat: ");
                    tempColumn1 = Console.ReadLine();
                    Console.WriteLine("Nhap sai!!!(Chi so cot ban nhap lon hon so cot ma tran va phai la so nguyen duong)");
                    Console.Write("Moi nhap lai dong thu hai: ");
                    tempColumn2 = Console.ReadLine();
				}
				else
				{
                    for (int i = 0; i < arrMatrix.GetLength(0); i++)
                    {
						int temp = arrMatrix[Column1, i];
						arrMatrix[Column1, i] = arrMatrix[Column2, i];
						arrMatrix[Column2, i] = temp;
                    }
                    Console.WriteLine("Ma tran sau khi hoan vi dong: ");
					XuatMangHaiChieu(arrMatrix);
					break;
                }
			}
        }

		//Xuat mang hai chieu
		static void XuatMangHaiChieu(int[,] arrMatrix)
		{
            for (int i = 0; i < arrMatrix.GetLength(0); i++)
            {
                Console.WriteLine("\n"); 
                for (int j = 0; j < arrMatrix.GetLength(1); j++)
                {
					Console.Write($"{arrMatrix[i,j]}  ");
                }
            }
        }


        #endregion

    }
}
