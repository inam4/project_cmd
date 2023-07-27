
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


            string S = "xzzzy";
            string re = "";
            string[] s_ = new string[S.Length];

            bool is_x = false;
            bool is_y = false;
            for (int x = 0; x < S.Length; x++)
            {
                re = re + S[S.Length - 1 - x];
            }
            for (int i = 0; i < S.Length; i++)
            {
                s_[i] = Convert.ToString(S[i]);
                if (S[i] == 'x')
                {
                    is_x = true;
                }
                if (S[i] == 'y')
                {
                    is_y = true;
                }
            }
            if (is_x == false && is_y == false)
            {
                //return (S.Length - 1);
            }

            string p = "";
            string j = "";
            int pattern = 0;
            for (int x = 0; x < S.Length; x++)
            {
                p = S.Substring(x, S.Length - x);
                j = re.Substring(x, re.Length - x);

                Console.WriteLine(p + " " + j);

                int x_left = 0;
                int x_right = 0;
                int y_left = 0;
                int y_right = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] == 'x')
                    {
                        x_left = x_left + 1;
                    }
                    else if (p[i] == 'y')
                    {
                        y_left = y_left + 1;
                    }
                }
                for (int d = 0; d < j.Length; d++)
                {

                    if (j[d] == 'x')
                    {
                        x_right = x_right + 1;
                    }
                    else if (j[d] == 'y')
                    {
                        y_right = y_right + 1;
                    }
                }
                if ((x_right==y_right)||(x_left==y_left))
                {
                    pattern = pattern + 1;
                }
            }
            //Console.WriteLine(pattern);
