using AiSD_cwiczenia_2;

internal class List
{
    public NodeL head;
    public NodeL tail;
    public int count = 0;

    public List()
    {
        this.count = 0;
        this.head = null;
        this.tail = null;
    }

    public void AddFirst(int liczba)
    {
        var tmp = new NodeL(liczba);

        if (head == null)
        {
            head = tmp;
            tail = tmp;
        }
        else
        {
            tmp.n = head;
            head.p = tmp;
            head = tmp;
        }

        count++;
    }

    public void AddLast(int liczba)
    {
        var tmp = new NodeL(liczba);

        if (tail == null)
        {
            head = tmp;
            tail = tmp;
        }
        else
        {
            tmp.p = tail;
            tail.n = tmp;
            tail = tmp;
        }

        count++;
    }

    public void deleteFirst()
    {
        if (head == null) return;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.n;
            head.p = null;
        }

        count--;
    }

    public void deleteLast()
    {
        if (tail == null) return;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.p;
            tail.n = null;
        }

        count--;
    }
    public String PrintList()
    {
        if (head == null)
        {          
            return  "Lista jest pusta";
        }

        var current = head;
        String tekst = "";
        while (current != null)
        {
            tekst += current.data;
            if(current.n != null) tekst += ",";
            current = current.n;
        }
        return tekst;
    }
}
