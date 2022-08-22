    public class Node 
    {
        public int nodeValue;
        public Node next;

        public Node(int x)
        {
            nodeValue = x;
            next = null;
        }
    }
   
    public static Node head = null;
    public static int size = 0;

        public static void insert_node(int position, int value) {
            if (position > size + 1)
            {
                return;
            }
            if (position == 1)
            {   
                Node temp = new Node(value);
                temp.next = head;
                head = temp;
            }
            else
            {
                int i = 1;
                Node temp = head;
                Node newNode = new Node(value);
                while(i < position - 1 && temp != null)
                {
                    temp = temp.next;
                    i++;
                }

                newNode.next = temp.next;
                temp.next = newNode;
            }
            size++;
        }

        public static void delete_node(int position) {
           if (position > size)
            {
                return;
            }

            if (position == 1)
            {
                head = head.next;
            }
            else
            {
                Node temp = head;
                int i = 1;
                while (i < position - 1 && temp != null)
                {
                    temp = temp.next;
                    i++;
                }

                temp.next = temp.next.next;
            }
            size--;
        }

        public static void print_ll() {
            Node temp = head;
            while(temp.next != null)
            {
                Console.Write("{0} ", temp.nodeValue);
                temp = temp.next;
            }
            Console.Write(temp.nodeValue);
        }
    
