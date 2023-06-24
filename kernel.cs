namespace os
{
	public class oss
	{	public static int rgb(int r, int g,int b){
				return ((r & 63)*2048) | ((g & 63) *32) | (b & 63);
		}
		unsafe public static void boxs(int x,int y,int x2,int y2,int colorss)
		{
			int f;
			int ff;
			int xx1=x;
			int xx2=x2;
			int xx3=x;
			int yy=y;
			int yy1=y;
			int yy2=y2;
			int yy3=y;
			int steeps;
			int steeps2;
			int location;
			int addss;
			int addss2;
			short *fbp=(short * )0x04100000;
			   int ii=colorss & 0xffff;
			   short c1=(short) ii;
			if(xx2<xx1){
				xx1=xx2;
				xx2=xx3;
			}
			if(yy2<yy1){
				yy1=yy2;
				yy2=yy3;
			}
			if(yy1<0)yy1=0;
			if(yy2<0)yy2=0;
			if(yy1>479)yy1=479;
			if(yy2>479)yy2=479;
			if(xx1<0)xx1=0;
			if(xx2<0)xx2=0;
			if(xx1>639)xx1=639;
			if(xx2>639)xx2=639;
                       
			location =  (640) * y + (x);
			steeps2=xx2-xx1;
			steeps=yy2-yy1;
			addss=1;
			addss2=((640-(xx2-xx1)));
			if(addss2<addss)addss2=0;
			for(f=0;f<steeps;f++){
				for(ff=0;ff<steeps2;ff++){
					*((short *)(fbp +  location)) =c1;

					location=location+addss;
				}
				location=location+addss2;
			}
}

		unsafe public static void vline(int x,int y,int y2,int colorss){
			int f;
			int yy1=y;
			int yy2=y2;
			int yy3=y;
			int xx=x;
			int steeps;
			int location;
			int addss;
			short *fbp=(short * )0x04100000;
			   int ii=colorss & 0xffff;
			   short c1=(short) ii;

			if(yy2<yy1){
				yy1=yy2;
				yy2=yy3;
			}
			if(xx<0)xx=0;
			if(xx>639)xx=639;
			if(yy1<0)yy1=0;
			if(yy2<0)yy2=0;
			if(yy1>479)yy1=479;
			if(yy2>479-1)yy2=479;
                       
			location =  (640) * y + (x);
			steeps=yy2-yy1;
			addss=640;
			for(f=0;f<steeps;f++){
 			    *((short *)(fbp +  location)) =c1;

				location=location+addss;
			}
	}
		unsafe public static void hline(int x,int y, int x2,int colorss) 
		{
			int f;
			int xx1=x;
			int xx2=x2;
			int xx3=x;
			int yy=y;
			int steeps;
			int location;
			int addss;
			short *fbp=(short * )0x04100000;
			   int ii=colorss & 0xffff;
			   short c1=(short) ii;

			if(xx2<xx1){
				xx1=xx2;
				xx2=xx3;
			}
			if(yy<0)yy=0;
			if(yy>479)yy=479;
			if(xx1<0)xx1=0;
			if(xx2<0)xx2=0;
			if(xx1>639)xx1=639;
			if(xx2>639)xx2=639;
                       
			location =  (640) * y + (x);
			steeps=xx2-xx1;
			addss=1;
			for(f=0;f<steeps;f++){
 			    *((short *)(fbp + location)) =c1;
			    
		
				location=location+addss;
			}
		
		
		}
		unsafe public static void clear(int colorss) 
		  {
			  			   // Clear the screen 
			   int ii=colorss & 0xffff;
			   short c1=(short) ii;
			   short *fbp=(short * )0x04100000;
			   for(int i = 0; i < 640 * 480 ; i++){
			    *((short *)(fbp +i)) =c1;
			    
			    
			   
			}
		  }
		  public static void kernel_main() 
		  {
			   // Clear the screen 
			int color1=rgb(0,0,63);
			int color2=rgb(0,0,0);
			int color3=rgb(63,63,63);
			int n=0;
			clear(color1);
			for(n=0;n<479;n=n+8)hline(0,n,639,color2);
			for(n=0;n<639;n=n+8)vline(n,0,479,color2);
			boxs(100,100,200,200,color3);
			while(true){}
			} 

		  public static void Main() 
		  {
			 kernel_main();
			}  
	    
		


}

}
