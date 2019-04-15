using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class BinaryTrees<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTrees<T> LeftTree { get; set; }
        public BinaryTrees<T> RightTree { get; set; }

        public BinaryTrees(T nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(T newItem)
        {
            T currentNodeValue = this.NodeData;

            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                //Left tree
                if(this.LeftTree == null)
                {
                    this.LeftTree = new BinaryTrees<T>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                //right tree
                if (this.RightTree == null)
                {
                    this.RightTree = new BinaryTrees<T>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }
       // ----      not finished 
     //   public string WalkTree()
     //   {
     //       string result = "";
     //
     //       if(this.LeftTree != null)
     //       {
     //           result = this.LeftTree.WalkTree();
     //       }
     //       result += $" {this.NodeData.ToString()} ";
     //       if (this.RightTree != null)
     //       {
     //
     //       }
     //   }
    }
}
