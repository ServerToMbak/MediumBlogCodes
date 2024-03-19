public class Program
{
    private static void Main(string[] args)
    {
        IWidgetFactory motifFactory = new MotifWidgetFactory();
        IWindow motifWindow = motifFactory.CreateWindow();
        IScrollBar motifScrollBar = motifFactory.CreateScrollBar();

        motifWindow.CreateWindow();
        motifScrollBar.CreateScrollBar();

        // PM platformu için fabrika oluştur
        IWidgetFactory pmFactory = new PMWidgetFactory();
        IWindow pmWindow = pmFactory.CreateWindow();
        IScrollBar pmScrollBar = pmFactory.CreateScrollBar();

        pmWindow.CreateWindow();
        pmScrollBar.CreateScrollBar();
    }

    interface IWindow
    {
        void CreateWindow();
    }

    class PMWindow : IWindow
    {
        public void CreateWindow()
        {
            Console.WriteLine("You have created PM Window");
        }
    }

    class MotifWindow : IWindow
    {
        void IWindow.CreateWindow()
        {
            Console.WriteLine("You have created a Motif winow");
        }
    }


    interface IScrollBar
    {
        void CreateScrollBar();
    }

    class MotifScrollBar : IScrollBar
    {
        public void CreateScrollBar()
        {
            Console.WriteLine("You have created a  Motif scrollbar ");
        }
    }

    class PMScrollBar : IScrollBar
    {
        public void CreateScrollBar()
        {
            Console.WriteLine("You have created a  PM scrollbar ");
        }
    }

    interface IWidgetFactory
    {
         IScrollBar CreateScrollBar();

         IWindow CreateWindow();
    }


    class MotifWidgetFactory : IWidgetFactory
    {
        public IScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();    
        }

        public IWindow CreateWindow()
        {
            return new MotifWindow();
        }
    }

    class PMWidgetFactory : IWidgetFactory
    {
        public IScrollBar CreateScrollBar()
        {
            return new PMScrollBar();
        }

        public IWindow CreateWindow()
        {
            return new PMWindow();
        }
    }
}