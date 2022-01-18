using System;
using System.Collections.Generic;
using System.Linq;

namespace IESLab2
{
    class Searcher
    {
        List<Node> Open;
        List<Node> Closed;
        LinkedList<Node> Path;
        public int Steps = 0;
        public void Start()
        {
            Open = new List<Node>(); //создание списков Open и Closed
            Closed = new List<Node>();
            Path = new LinkedList<Node>();
            Open.Add(new Node()); //Кладёт начальное состояние в список Open
        }
        
        private Boolean Contains(Node node, List<Node> nodes)//функция, определяющая, содержится ли вершина в каком-либо списке
        {
            foreach(var item in nodes)
            {
                if (item.Equals(node)) return true;
            }
            return false;
        }

        public void DepthSearch(int level = 100) //максимальный уровень
        {
            Node node = Open.First();
            while (!node.IsEnd())
            {
                Open.Remove(node);
                Closed.Add(node);

                if (node.GetStatus())
                {
                    var children = node.GetChildren().Where(item => !Contains(item, Open) && !Contains(item, Closed) && item.GetLevel() < level);
                    Open.InsertRange(0, children); //внесение неотсеенных дочерних состояний в начало списка Open
                }

                Steps++;
                if (Open.Count > 0)
                {
                    node = Open.First();
                }
                else
                {
                    throw new Exception("Not found");
                }
            }

            Path.AddFirst(node);
            NodeToPath();
        }

        public void WidthSearch()
        {
            Node node = Open.First(); 
            while (Open.Count > 0 && !node.IsEnd()) //проверка состояние на соответствие целевому, а также на заполненность Open
            {
                Open.Remove(node);//
                Closed.Add(node);//перекладываем элемент из Open в Closed
                if (node.GetStatus()) //проверка состояния на правильность
                { //кладём в конец Open все дочерние состояния и отсеиваем все содержащиеся в Open или Closed
                    Open.AddRange(node.GetChildren().Where(item => !Contains(item, Open) && !Contains(item, Closed)));
                }

                Steps++;
                node = Open.First();
            }

            Path.AddFirst(node);
            NodeToPath();
        }

        public LinkedList<String> GetPath()
        {
            LinkedList<String> outPath = new LinkedList<String>();
            foreach(var item in Path)
            {
                outPath.AddLast(item.GetItem());
            }
            return outPath;
        }

        void NodeToPath() //метод, восстанавливающий путь от начального состояния до целевого
        {
            Node node = Path.First().GetParent();
            while(node != null)
            {
                Path.AddFirst(node);
                node = node.GetParent();
            }
        }

        class Node
        {
            Boolean humanIsLeft, wolfIsLeft, goatIsLeft, cabbageIsLeft; //переменные, отвечающие за положение субъектов
            Node parent; //состояние-родитель
            int level; //уровень, нам котором состояние находится
            public Node() { //определение начального местоположения (false - левый берег, true - правый)
                level = 0;
                humanIsLeft = false;
                wolfIsLeft = !false;
                goatIsLeft = false;
                cabbageIsLeft = !false;
            }
            public Boolean IsEnd() //функция, определяющее, является ли состояние целевым (также позволяет настроить его)
            {
                return humanIsLeft && wolfIsLeft && goatIsLeft && !cabbageIsLeft;
            }

            Node(Node parent, Boolean humanIsLeft, Boolean wolfIsLeft,
                Boolean goatIsLeft, Boolean cabbageIsLeft, int level)
            { // конструктор, позволяющий создавать дочерние состояния
                this.parent = parent;
                this.humanIsLeft = humanIsLeft;
                this.wolfIsLeft = wolfIsLeft;
                this.goatIsLeft = goatIsLeft;
                this.cabbageIsLeft = cabbageIsLeft;
                this.level = level;
            }

            public Node GetParent() { return parent; } //возвращает родителя
            public Boolean GetStatus()
            { //метод, проверяющий коректность состояния
                return !(!humanIsLeft.Equals(wolfIsLeft) && wolfIsLeft.Equals(goatIsLeft) ||
                    !humanIsLeft.Equals(goatIsLeft) && cabbageIsLeft.Equals(goatIsLeft));
            }

            public Boolean Equals(Node another)
            { //метод, сравнивающий между собой 2 состояния
                return this.humanIsLeft.Equals(another.humanIsLeft) &&
                    this.wolfIsLeft.Equals(another.wolfIsLeft) &&
                    this.goatIsLeft.Equals(another.goatIsLeft) &&
                    this.cabbageIsLeft.Equals(another.cabbageIsLeft);
            }

            public List<Node> GetChildren()
            { //метод порождения дочерних вершин, он создаёт все возможные состояния
                var children = new List<Node>();
                children.Add(new Node(this, !humanIsLeft, wolfIsLeft, goatIsLeft, cabbageIsLeft, level+1));
                if (humanIsLeft.Equals(wolfIsLeft))
                    children.Add(new Node(this, !humanIsLeft, !wolfIsLeft, goatIsLeft, cabbageIsLeft, level + 1));
                if (humanIsLeft.Equals(goatIsLeft))
                    children.Add(new Node(this, !humanIsLeft, wolfIsLeft, !goatIsLeft, cabbageIsLeft, level + 1));
                if (humanIsLeft.Equals(cabbageIsLeft))
                    children.Add(new Node(this, !humanIsLeft, wolfIsLeft, goatIsLeft, !cabbageIsLeft, level + 1));

                return children;
            }

            public int GetLevel() // возвращает уровень
            {
                return level;
            }

            public String GetItem() //возвращает текстовую строку описания состояния для последующего вывода
            {
                return String.Format("Ч({0}) - В({1}) - Коз({2}) - К({3})", humanIsLeft ? "П":"Л",
                    wolfIsLeft ? "П" : "Л", goatIsLeft ? "П" : "Л", cabbageIsLeft ? "П" : "Л");
            }

        }
    }
}
