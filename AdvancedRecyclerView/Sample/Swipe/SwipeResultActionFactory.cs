using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.Action;
using MvvmCross.AdvancedRecyclerView.Adapters;
using MvvmCross.AdvancedRecyclerView.Swipe;
using MvvmCross.AdvancedRecyclerView.Swipe.ResultActions;

namespace Sample.Swipe
{
    class SwipeResultActionFactory : MvxSwipeResultActionFactory
    {
        public override SwipeResultAction GetSwipeLeftResultAction(MvxAdvancedRecyclerViewAdapter adapter, int position)
        {
            return new MvxSwipeToDirectionResultAction(adapter, SwipeDirection.FromRight, position);
        }

        public override SwipeResultAction GetSwipeRightResultAction(MvxAdvancedRecyclerViewAdapter adapter, int position)
        {
            return new MvxSwipeUnpinResultAction(adapter, position);
        }

        public override SwipeResultAction GetUnpinSwipeResultAction(MvxAdvancedRecyclerViewAdapter adapter, int position)
        {
            return new MvxSwipeUnpinResultAction(adapter, position);
        }
    }
}