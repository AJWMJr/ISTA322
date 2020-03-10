using System;

namespace cssbs_lab17
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }
        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            if (this.LeftTree == null)
            {
                this.LeftTree = new Tree<TItem>(newItem);
            }
            else
            {
                this.LeftTree.Insert(newItem);
            }
        }
        public string WalkTree()
        {
            string result = "";
            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }
            result += $" {this.NodeData.ToString()} ";
            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }
            return result;
        }
    }
}
