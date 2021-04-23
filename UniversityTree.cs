using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity1
{
    class UniversityTree
    {
        public PositionNode Root;                            //Atributo de la clase

        public void CreatePosition(
            PositionNode parent, 
            Position positionToCreate,
            string parentPositionName)        //Parametro del Metodo
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if(Root == null)  //Arbol Vacio
            {
                Root = newNode;
                return;
            }
            if(parent == null)
            {
                return;
            }

            if (parent.Position.Name == parentPositionName)
            {
                if(parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
            
        }
        public void PrintTree(PositionNode from)
        {
            if(from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }
        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);

        }
    }
}
