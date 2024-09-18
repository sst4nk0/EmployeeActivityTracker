using System.Drawing;

namespace EmployeeActivityTracker
{
    internal class WindowDrag
    {
        private static bool draggingState = false;
        private static Point dragingStartPoint = new Point(0, 0);
        public static bool dragState
        {
            get { return draggingState; }
            set { draggingState = value; }
        }
        public static Point dragStartPoint
        {
            get { return dragingStartPoint; }
            set { dragingStartPoint = value; }
        }
    }
}
