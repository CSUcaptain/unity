// 二叉树的前序、中序、后序遍历
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class TreeTraversing
    {
        public struct treeItem
        {
            public string data;
            public int leftIndex;
            public int rightIndex;
        }

        treeItem[] treeArr;

        static void Main(string[] args)
        {
            TreeTraversing p = new TreeTraversing();
            p.CreateTree();

            Console.Write("前序遍历：");
            p.PreOrderTraverse(p.treeArr[0]);
            Console.Write("\n中序遍历：");
            p.InOrderTraverse(p.treeArr[0]);
            Console.Write("\n后序遍历：");
            p.PostOrderTraverse(p.treeArr[0]);

            Console.WriteLine("\n完毕，恭喜！");
            Console.ReadLine();
        }

        public void CreateTree()
        {
            treeArr = new treeItem[9];

            treeArr[0].data = "A";
            treeArr[0].leftIndex = 1;
            treeArr[0].rightIndex = 2;

            treeArr[1].data = "B";
            treeArr[1].leftIndex = 3;
            treeArr[1].rightIndex = -1;

            treeArr[2].data = "C";
            treeArr[2].leftIndex = 4;
            treeArr[2].rightIndex = 5;

            treeArr[3].data = "D";
            treeArr[3].leftIndex = 6;
            treeArr[3].rightIndex = 7;

            treeArr[4].data = "E";
            treeArr[4].leftIndex = -1;
            treeArr[4].rightIndex = 8;

            treeArr[5].data = "F";
            treeArr[5].leftIndex = -1;
            treeArr[5].rightIndex = -1;

            treeArr[6].data = "G";
            treeArr[6].leftIndex = -1;
            treeArr[6].rightIndex = -1;

            treeArr[7].data = "H";
            treeArr[7].leftIndex = -1;
            treeArr[7].rightIndex = -1;

            treeArr[8].data = "I";
            treeArr[8].leftIndex = -1;
            treeArr[8].rightIndex = -1;

        }

        // 前序遍历
        public void PreOrderTraverse(treeItem rootNode)
        {
            treeItem node = rootNode;
            Console.Write(node.data);
            if (node.leftIndex != -1)
                PreOrderTraverse(treeArr[node.leftIndex]);
            if(node.rightIndex != -1)
                PreOrderTraverse(treeArr[node.rightIndex]);
        }

        // 中序遍历
        public void InOrderTraverse(treeItem rootNode)
        {
            treeItem node = rootNode;
            if (node.leftIndex != -1)
                InOrderTraverse(treeArr[node.leftIndex]);
            Console.Write(node.data);
            if (node.rightIndex != -1)
                InOrderTraverse(treeArr[node.rightIndex]);
        }

        // 后续遍历
        public void PostOrderTraverse(treeItem rootNode)
        {
            treeItem node = rootNode;
            if (node.leftIndex != -1)
                PostOrderTraverse(treeArr[node.leftIndex]);
            if (node.rightIndex != -1)
                PostOrderTraverse(treeArr[node.rightIndex]);
            Console.Write(node.data);
        }
    }
}
