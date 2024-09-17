namespace Project
{
    public class Segment_tree
    {
        private int n;
        private List<int> arr;
        private List<int> sg;
 

        public Segment_tree(List<int> a,int sz) {
            n = sz;
            arr = a;
            int z = 4 * n;
            sg = new List<int>();
            for (int i = 0; i < z; i++)
            {
                sg.Add(0);
            }
            build(1, 0, n - 1);
        }
        private void build(int ind,int st,int en)
        {
            if(st == en)
            {
                sg[ind] = arr[st];
                return;
            }
            int lf = ind * 2, mid = (st + en)/2;
            int ri = lf + 1;
            build(lf, st, mid);
            build(ri, mid+1, en);
            sg[ind] = Math.Max(sg[lf], sg[ri]);
            return;
        }

        private int get_max(int l, int r, int ind,int st,int en)
        {
            if (st > r || en < l) return 0;

            if (st >= l && en <= r) return sg[ind];

            int lf = ind * 2, ri = lf + 1, mid = (st + en) >> 1;

            return Math.Max(get_max(l,r,lf,st,mid), get_max(l, r, ri, mid+1, en));
        }
       
        public int get_max(int l,int r)
        {
            return get_max(l,r,1,0,n-1);
        }

    }
}
