
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




            string S = "babbb";
            int pos_a = 0;
            int pos_b = 0;
            bool is_a = true;
            bool is_b = false;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == Convert.ToChar('a'))
                {
                    pos_a = i;
                    is_a = true;
                }
                else if (S[i] == Convert.ToChar('b'))
                {
                    pos_b = i;
                    is_b = true;
                }
            }
            if ((pos_a < pos_b) && is_a == true && is_b == true)
            {
                Console.WriteLine("True");
            }
            else if ((pos_a > pos_b) && is_a == true && is_b == true)
            {
                Console.WriteLine("false");
            }
            else if (is_a == true || is_b == true)
            {
                Console.WriteLine("true");
            }
            else if (is_a == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

