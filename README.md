
            int a_zero = 0;
            int a_one = 0;
            int[] A = { 1, 0, 1, 0, 1, 1 };
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (A[i] != 0)
                    {
                        a_zero = a_zero + 1;
                    }
                    else if (A[i] != 1)
                    {
                        a_one = a_one + 1;
                    }
                }
                else
                {
                    if (A[i] != 1)
                    {
                        a_zero = a_zero + 1;
                    }
                    else if (A[i] != 0)
                    {
                        a_one = a_one + 1;
                    }
                }
            }
            if (a_one > a_zero)
            {
                Console.WriteLine("Frist " + a_zero);
            }
            else if (a_one < a_zero)
            {
                Console.WriteLine("2nd " + a_one);
            }
            else
            {
                Console.WriteLine(a_zero);
            }
