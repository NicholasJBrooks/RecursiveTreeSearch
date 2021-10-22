using System;

namespace RecursionPetName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a tree and then iterate through the left side of the tree concatnating the name of all the pets with a , inbetween


            // Make the tree look like this
            //                                                          Tim
            //                                              Max                     Ryder
            //                                      Lucy           Boo          Sammy           Shimmer
            //                                  cass    Tommy  Larry  null   null   null      null    null 


            // Answer should be 
            //    Cass, Lucy, Max , Tim
            IPet Tim = new IPet { Name = "Tim" };

            IPet Max = new IPet { Name = "Max" };

            IPet Ryder = new IPet { Name = "Ryder" };

            IPet Lucy = new IPet { Name = "Lucy" };

            IPet Boo = new IPet { Name = "Boo" };

            IPet Sammy = new IPet { Name = "Sammy" };

            IPet Shimmer = new IPet { Name = "Shimmer" };

            IPet Cass = new IPet { Name = "Cass" };

            IPet Tommy = new IPet { Name = "Tommy" };

            IPet Larry = new IPet { Name = "Larry" };

            Node one = new Node
            {
                Current = Tim
            };

            Node two = new Node
            {
                Current = Max
            };

            Node three = new Node
            {
                Current = Ryder
            };

            Node four = new Node
            {
                Current = Lucy
            };



            Node five = new Node
            {
                Current = Boo
            };

            Node six = new Node
            {
                Current = Sammy
            };

            Node seven = new Node
            {
                Current = Shimmer
            };

            Node eight = new Node
            {
                Current = Cass
            };

            Node nine = new Node
            {
                Current = Tommy
            };

            Node ten = new Node
            {
                Current = Larry
            };

            one.Left = two;
            one.Right = three;

            two.Left = four;
            two.Right = five;

            three.Left = six;
            three.Right = seven;

            four.Left = eight;
            four.Right = nine;

            five.Left = ten;

            string list = "";

            list += FindNameLeftOfTree(one);

            Console.WriteLine(list);
            Console.ReadLine(); 
        }



        public static string FindNameLeftOfTree(Node position)

        {

            string name = "";

            if (position.Left != null)
            {
                name += FindNameLeftOfTree(position.Left) +","+ position.Current.Name;
            }
            else
            {
                name = position.Current.Name;
            }

            return name;
        }
    }
}


class IPet
{

    public string Name { get; set; }

    public string Sound { get; set; }

    public string Type { get; set; }

}



class Node
{

    public IPet Current { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

}


