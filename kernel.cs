namespace os
{
	public class oss
	{
		  unsafe public static void kernel_main() 
		  {
			   // Clear the screen 
			   
			   char *fbp=(char * )0x04100000;
			   char i15=(char)15;
			   char i0=(char)0;
			   for(int i = 0; i < 640 * 480 *2; i=i+2){
			    *((char *)(fbp + i)) = i15;
			    *((char *)(fbp + i+1)) = i0;
			   
			}
			while(true){}
			} 

		  unsafe public static void Main() 
		  {
			 kernel_main();
			}  
	    
		


}

}
