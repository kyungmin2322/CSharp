using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class Program
    {
		/*
        class Singleton
        {
            private Singleton()
            {

            }

            static Singleton instance;

            static public Singleton GetInstance()
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
        */
        /* 20250224
		//Network에 접속 했지만 비밀번호가 틀리다.
		class CustomException : Exception
		{
			public CustomException() : base("이거 내가 만든 예외")
			{
			}
		}

		class WrongPasswordException : Exception
		{
			public WrongPasswordException() : base("비번 틀림")
			{
			}
		}
        */
		static void Main(string[] args)
        {
            //Engine.Instance.Load();
            //Engine.Instance.Run();
            /*
            // Sort(정렬)
            int [] numbers = { 1, 5, 2, 3, 6, 7, 8, 10, 9 };

            // 1 -> 10 : 올림차순, ascending
            // 10 -> 1 : 내림차순, descending
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] - numbers[j] > 0) // == numbers[i] - numbers[j] > 0
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            */
            /* 20250224
            StreamReader sr = null;
			try
            {
                List<string> scene = new List<string>();

                sr = new StreamReader("level02.map");
                while(!sr.EndOfStream)
                {
                    scene.Add(sr.ReadLine());
					//throw new CustomException();
				}
				// throw new WrongPasswordException();
            }
            catch(FileNotFoundException ex)
            {
				Console.WriteLine(ex.FileName);
                Console.WriteLine(ex.Source);
				Console.WriteLine(ex.Message);
            }
            catch(WrongPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
				//network, file 입출력
				Console.WriteLine("finally");
				sr.Close();
			}
            */

            Engine.Instance.Init();

            Engine.Instance.Load("level01.map");
            Engine.Instance.Run();

            Engine.Instance.Quit();
		}
    }
}
