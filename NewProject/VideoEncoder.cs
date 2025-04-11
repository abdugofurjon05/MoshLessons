namespace NewProject
{
    public class VideoEncoder
    {

        public delegate void VideoEncodedEvenHandler(object source, EventArgs e);
        public event VideoEncodedEvenHandler VideoEncoded;






        public void Encode(Video video)
        {
            Console.WriteLine("encoding ...");
            Thread.Sleep(3000);



            onVideoEncoded();



        }



        protected virtual void onVideoEncoded()
        {
            if(VideoEncoded != null) 
                VideoEncoded(this, EventArgs.Empty);
        }


 
    }
}