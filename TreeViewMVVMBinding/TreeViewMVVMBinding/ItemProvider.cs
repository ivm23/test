using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVMBinding
{
    public class NodeProvider
    {
        private readonly DirectoryNode _rootDirectoryNode;

        public NodeProvider()
        {
            _rootDirectoryNode = new DirectoryNode { Name = "X" };

            var childNode = new DirectoryNode { Name = "A" };

            var grandChildNode1 = new DirectoryNode { Name = "A1" };
            var grandChildNode2 = new DirectoryNode { Name = "A2" };

            var greatgrandChildNode2 = new DirectoryNode { Name = "A2_1" };
            grandChildNode1.AddDirNode(greatgrandChildNode2);

            childNode.AddDirNode(grandChildNode1);
            childNode.AddDirNode(grandChildNode2);

            var childNode2 = new DirectoryNode { Name = "B" };
            var childNode3 = new DirectoryNode { Name = "C" };
            var childNode4 = new DirectoryNode { Name = "D" };

            var grandChildNode121 = new DirectoryNode { Name = "B1" };
            childNode2.AddDirNode(grandChildNode121);

            var childList1 = new List<DirectoryNode>
         {
            childNode,
            childNode2,
            childNode3,
            childNode4
         };

            _rootDirectoryNode.Items = childList1;
        }

        public List<Node> DirItems => _rootDirectoryNode.Traverse(_rootDirectoryNode);
    }
}
