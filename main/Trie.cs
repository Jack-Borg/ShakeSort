using System;

namespace main
{
    public class Trie
    {
        public static String[] Sort(String[] arr)
        {
            Node root = new Node();
            foreach (string s in arr)
            {
                root.Insert(s, 0);
            }

            return root.ToArray(arr.Length - 1);
        }

        private static int index = 0;

        private class Node
        {
            private Node[] subNodes;
            private String endString;
            private int count;

            public Node()
            {
                subNodes = new Node[28];
            }

            public void Insert(String str, int index)
            {
                if (index == str.Length)
                {
                    if (endString != null && endString.Equals(str))
                        count++;
                    else
                        endString = str;
                }
                else
                {
                    char c = str[index];

                    int charIndex = valueOfChar(c);

                    if (subNodes[charIndex] == null)
                    {
                        subNodes[charIndex] = new Node();
                    }

                    subNodes[charIndex].Insert(str, ++index);
                }
            }


            public String[] ToArray(int size)
            {
                String[] arr = new String[size];
                index = 0;
                ToArray(arr);
                return arr;
            }

            private void ToArray(String[] arr)
            {
                if (endString != null)
                {
                    for (int i = 0; i < count; i++)
                    {
                        arr[index] = endString;
                        index += 1;
                    }
                }

                foreach (Node n in subNodes)
                    if (n != null)
                        n.ToArray(arr);
            }

            public void Print()
            {
                if (endString != null)
                    Console.WriteLine(endString);
                foreach (Node n in subNodes)
                {
                    if (n != null)
                        n.Print();
                }
            }

            private int valueOfChar(char c)
            {
                switch (c)
                {
                    case '-':
                        return 0;
                    case '\'':
                        return 1;
                    default:
                        return c - 95;
                }
            }
        }
    }
}