using DPProject.Composite;
using DPProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DPProject
{
    internal class Branch
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public ItemsState State { get; set; }
        public List<ItemContext> Items { get; set; }


        public Branch(string Name, ItemsState State, List<ItemContext> Items)
        {
            this.Name = Name;
            this.State = State;
            this.Items = Items;
        }

        public Branch()
        {
            
        }

        public string Commited()
        {
            string s = " ";
            for (var i = 0; i < Items.Count; i++)
            {
                s = $"{this.Items[i].State.Commited(Items[i])}";
            }
            return s;
        }

        public string ReadyToMerge(Branch b, Branch branch)
        {
            string s = " ";
            for (var i = 0; i < Items.Count; i++)
            {
                s = $"{b.Items[i].State.Merged(Items[i],Items[i])} is ready to merge";
            }
            return s;
        }

        public string Merged(Branch b, Branch branch)
        {
            string s = " ";
            for (var i = 0; i < Items.Count; i++)
            {
               s=$"{ b.Items[i].State.Merged(Items[i], Items[i])} was merged";
            }
            return s;
        }

        public string Staged()
        {
            string s = " ";
            for (var i = 0; i < Items.Count; i++)
            {
                s = $"{this.Items[i].State.Staged(Items[i])}";
            }
            return s;
        }
        public string UnderReview()
        {
            string s = " ";
            for (var i = 0; i < Items.Count; i++)
            {
                s = $"{this.Items[i].State.UnderReview(Items[i])}";
            }
            return s;
        }



        public void Add(ItemContext itemContext)
        {
             Items.Add(itemContext);
        }
        public void Update(ItemContext itemContext)
        {
            ItemContext item = Items.Find(n => n.Name == itemContext.Name);
            if (item == null)
            {
                Add(itemContext);
            }
            else
            {
                item = itemContext;
            }
        }
        public string Clone(Branch b)
        {
            Branch branch = new Branch();
            branch.Name = b.Name;
            branch.Type = b.Type;
            branch.State = b.State;
            branch.Items = b.Items;
            //for (var i = 0; i < b.Items.Count; i++)
            //{
            //    branch.Items[i] = b.Items[i];
            //}
            return $"{branch.Name} was cloned";
        }
        public void Undo()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Undo();
            }

        }
        public string BranchDetails()
        {
            string s = $"Branch name :{Name}";
            for (var i = 0; i < Items.Count; i++)
            {
                s += $"{this.Items[i].ShowDetails("")}";
            }
            return s;
        }





    }
}
