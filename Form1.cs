using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using WMPLib;

namespace AI_VOICE_RECOGNITION_BENNETT_TANYAG
{

    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEng = new SpeechRecognitionEngine();
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private string currentFloor = ""; // Tracks the current floor being displayed
        private List<int> currentImageTimings = null; // Holds timing intervals for the current floor
        private ImageList currentImageList = null; // Holds images for the current floor
        private int currentImageIndex = 0; // Tracks the current image index
        private Dictionary<string, List<int>> floorImageTimings = new Dictionary<string, List<int>>();
        private Dictionary<string, ImageList> floorImageLists = new Dictionary<string, ImageList>();

        private List<Image> preloadedImages;

        private void PreloadImages(ImageList imageList)
        {
            preloadedImages = new List<Image>();
            foreach (Image img in imageList.Images)
            {
                preloadedImages.Add(new Bitmap(img)); // Create a bitmap copy to preload
            }
        }

        private void StartSlideshow(string floor)
        {
            if (floorImageTimings.ContainsKey(floor) && floorImageLists.ContainsKey(floor))
            {
                currentFloor = floor;
                currentImageTimings = floorImageTimings[floor];
                currentImageList = floorImageLists[floor];

                if (currentImageList.Images.Count != currentImageTimings.Count)
                {
                    Console.WriteLine("Mismatch: Number of images and timings do not match!");
                    return;
                }

                currentImageIndex = 0;

                if (currentImageList.Images.Count > 0)
                {
                    // Preload images for smoother transitions
                    PreloadImages(currentImageList);

                    // Start timer with the delay for the first image
                    timer1.Interval = currentImageTimings[currentImageIndex];
                    timer1.Start();
                    Console.WriteLine($"Slideshow started for floor: {floor}");
                }
                else
                {
                    Console.WriteLine($"No images found for {floor}.");
                }
            }
            else
            {
                Console.WriteLine($"Floor data not initialized properly for {floor}.");
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (currentImageTimings != null && preloadedImages != null && preloadedImages.Count > 0)
            {
                if (currentImageIndex < preloadedImages.Count)
                {
                    // Display the current preloaded image
                    pictureBox1.Image = preloadedImages[currentImageIndex];
                    Console.WriteLine($"Displaying image index {currentImageIndex} for floor {currentFloor}.");

                    // Increment the index and set the next delay if there are more images
                    currentImageIndex++;

                    if (currentImageIndex < preloadedImages.Count)
                    {
                        timer1.Interval = currentImageTimings[currentImageIndex];
                    }
                    else
                    {
                        // Stop the slideshow if all images have been displayed
                        timer1.Stop();
                        Console.WriteLine($"Slideshow completed for floor {currentFloor}.");
                    }
                }
            }
            else
            {
                timer1.Stop();
                Console.WriteLine("No images or timings available for slideshow.");
            }
        }

        private void InitializeFloorData()
        {
            // Ground floor setup
            floorImageLists["ground"] = groundFloorImageList;
            floorImageTimings["ground"] = new List<int> { 4000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };

            // Additional floors can be added similarly
            floorImageLists["mezzanine"] = mezzanineFloorImageList;
            floorImageTimings["mezzanine"] = new List<int> { 4000, 1000, 1000, 1000, 1000 };

            // Second floor
            floorImageLists["second"] = secondFloorImageList;
            floorImageTimings["second"] = new List<int> { 4000, 1000 };

            // Third floor
            floorImageLists["third"] = thirdFloorImageList;
            floorImageTimings["third"] = new List<int> { 4000 };

            // Fourth floor
            floorImageLists["fourth"] = fourthFloorImageList;
            floorImageTimings["fourth"] = new List<int> { 4000 };

            // Fifth floor
            floorImageLists["fifth"] = fifthFloorImageList;
            floorImageTimings["fifth"] = new List<int> { 4000, 1000, 1000 };

            // Sixth floor
            floorImageLists["sixth"] = sixthFloorImageList;
            floorImageTimings["sixth"] = new List<int> { 4000 };

            // Seventh floor
            floorImageLists["seventh"] = seventhFloorImageList;
            floorImageTimings["seventh"] = new List<int> { 4000, 1000, 1000, 1000, 1000, 1000, 1000 };

            // Eighth floor
            floorImageLists["eighth"] = eighthFloorImageList;
            floorImageTimings["eighth"] = new List<int> { 4000, 1000 };

            // Ninth floor
            floorImageLists["ninth"] = ninthFloorImageList;
            floorImageTimings["ninth"] = new List<int> { 4000 };

            // Tenth floor
            floorImageLists["tenth"] = tenthFloorImageList;
            floorImageTimings["tenth"] = new List<int> { 4000, 1000, 1000, 1000, 1000 };

            // Twelfth floor
            floorImageLists["twelfth"] = twelfthFloorImageList;
            floorImageTimings["twelfth"] = new List<int> { 4000, 1000 };

            // Lower Penthouse floor (lpFloor)
            floorImageLists["lpFloor"] = lpFloorImageList;
            floorImageTimings["lpFloor"] = new List<int> { 4000, 1000, 1000, 1000 };

            // Upper Penthouse floor (upFloor)
            floorImageLists["upFloor"] = upFloorImageList;
            floorImageTimings["upFloor"] = new List<int> { 4000, 1000 };

            Console.WriteLine("Floor data initialized.");
            foreach (var floor in floorImageLists.Keys)
            {
                Console.WriteLine($"Floor '{floor}' has {floorImageLists[floor].Images.Count} images.");
            }
        }



        public Form1()
        {
            InitializeComponent();
            mediaPlayer.uiMode = "none";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFloorData();
            /*txtSpeech.SelectionStart = txtSpeech.Text.Length;
            txtSpeech.ScrollToCaret();*/

            try
            {
                
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
                Choices commands = new Choices();

                // Commands using varied phrases
                commands.Add(new string[] {
                // General iACADEMY Information
                "What is iACADEMY", "Tell me about iACADEMY", "Introduce iACADEMY", "Give me information on iACADEMY",
            
                // Facilities on each floor
                "What facilities are on ground floor", "What is on the ground floor", "Describe ground floor", "Tell me about the ground floor",
                "What facilities are on mezzanine floor", "What is on the mezzanine floor", "Describe mezzanine floor", "Tell me about the mezzanine",
                "What facilities are on second floor", "What is on the second floor", "Describe second floor", "Tell me about the second floor",
                "What facilities are on third floor", "What is on the third floor", "Describe third floor", "Tell me about the third floor",
                "What facilities are on fourth floor", "What is on the fourth floor", "Describe fourth floor", "Tell me about the fourth floor",
                "What facilities are on fifth floor", "What is on the fifth floor", "Describe fifth floor", "Tell me about the fifth floor",
                "What facilities are on sixth floor", "What is on the sixth floor", "Describe sixth floor", "Tell me about the sixth floor",
                "What facilities are on seventh floor", "What is on the seventh floor", "Describe seventh floor", "Tell me about the seventh floor",
                "What facilities are on eighth floor", "What is on the eighth floor", "Describe eighth floor", "Tell me about the eighth floor",
                "What facilities are on ninth floor", "What is on the ninth floor", "Describe ninth floor", "Tell me about the ninth floor",
                "What facilities are on tenth floor", "What is on the tenth floor", "Describe tenth floor", "Tell me about the tenth floor",
                "What facilities are on twelfth floor", "What is on the twelfth floor", "Describe twelfth floor", "Tell me about the twelfth floor",
                "What facilities are on lower penthouse floor", "What is on the lower penthouse floor", "Describe lower penthouse floor", "Tell me about the lower penthouse floor",
                "What facilities are on upper penthouse floor", "What is on the upper penthouse floor", "Describe upper penthouse floor", "Tell me about the upper penthouse floor",
            
                // Payment Options
                "What are the payment options", "How can I pay my tuition", "How do I pay tuition", "Payment methods available", "Tuition payment options",
            
                // Organizations and Clubs
                "List the organizations", "Available clubs", "Student groups", "What organizations are there", "Tell me about student organizations",
            
                // Courses and Programs
                "List the courses", "What programs are offered", "Available courses", "What courses are there", "Tell me about programs offered",
            
                // Exiting commands
                "Goodbye", "Bye bot", "Exit", "See you later", "Quit", "End session", "I'm done"
                });


                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                Grammar grammar = new Grammar(gBuilder);

                recEng.LoadGrammarAsync(grammar);
                recEng.SetInputToDefaultAudioDevice();
                recEng.SpeechRecognized += RecEng_SpeechRecognized;
                recEng.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            txtSpeech.Text = "iAC tour is now in operation";
            synth.Speak("Ayak tour is now in operation");
        }

        private void RecEng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string s = "";
            string videoPath = "C:\\Users\\ronan\\OneDrive - St John's Lutheran Church\\iACADEMY\\3rd Year\\IntroToAI\\Project\\iACTour\\ai_videos\\";

            if (btnEnable.Enabled == false)
            {
                mediaPlayer.settings.volume = 500;
                string recognizedText = e.Result.Text.ToLower();

                // Basic information about iACADEMY
                if (recognizedText.Contains("what is iacademy") || recognizedText.Contains("tell me about iacademy") || recognizedText.Contains("introduce iacademy"))
                {
                    s = "Information and Communications Technology Academy, better known as iACADEMY, is a private, non-sectarian educational institution in the Philippines. The school offers hands-on, industry-aligned curriculums in Computer Science, Multimedia Arts and Design, and Business. Visit iacademy.edu.ph for more.";

                    mediaPlayer.URL = videoPath + "iacademy.mov";
                    mediaPlayer.Ctlcontrols.play();
                    mediaPlayer.settings.volume = 100;

                }
                // Floor-related commands, using basic keyword matching for floor names
                else if (recognizedText.Contains("floor"))
                {
                    // Define floor facilities dictionary
                    var facilitiesByFloor = new Dictionary<string, string>
                    {
                        { "ground", "Building Lobby, Turnstile System, Equipment Center, Partner’s Hive, Gamers Hive, ATM, Admissions, Registrar, Finance, Clinic" },
                        { "mezzanine", "Meeting Rooms, OSAS, ELPD, IT Department, HR, Executive Office" },
                        { "second", "Parking, Purchasing Department, Facilities Stock Room" },
                        { "third", "Admin Office, Parking Area" },
                        { "fourth", "Parking Area" },
                        { "fifth", "Cafeteria, Grass Area / Student Lounge, Employee Lounge" },
                        { "sixth", "SHS Library" },
                        { "seventh", "Sewing Room, Fashion Design Room, Sound Room, Multimedia Arts Laboratory" },
                        { "eighth", "Faculty Room, MMA Lab" },
                        { "ninth", "College Library" },
                        { "tenth", "Lightbox Room, Mac Lab, Unity Game Lab, Wet/Dry Drawing Room, Chemistry Lab" },
                        { "twelfth", "Auditorium, Multipurpose Hall, Nexus Gallery" },
                        { "lower penthouse", "Gymnasium, PE Room, Garden Deck" },
                        { "upper penthouse", "Running Track, Library" }
                    };

                    // Check each floor to see if its name is in the recognized text
                    bool floorFound = false;
                    foreach (var floor in facilitiesByFloor.Keys)
                    {
                        if (recognizedText.Contains(floor))
                        {
                            s = $"Facilities on the {floor} floor include: {facilitiesByFloor[floor]}.";
                            floorFound = true;

                            if (floor == "ground")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "ground.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("ground");
                            }

                            if (floor == "mezzanine")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "mez.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("mezzanine");
                            }

                            if (floor == "second")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "second.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("second");
                            }

                            if (floor == "third")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "third.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("third");
                            }

                            if (floor == "fourth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "fourth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("fourth");
                            }

                            if (floor == "fifth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "fifth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("fifth");
                            }

                            if (floor == "sixth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "sixth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("sixth");
                            }

                            if (floor == "seventh")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "seventh.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("seventh");
                            }

                            if (floor == "eighth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "eighth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("eighth");
                            }

                            if (floor == "ninth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "ninth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("ninth");
                            }

                            if (floor == "tenth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "tenth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("tenth");
                            }

                            if (floor == "twelfth")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "twelfth.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("twelfth");
                            }

                            if (floor == "lower penthouse")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "lp.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("lpFloor");
                            }

                            if (floor == "upper penthouse")
                            {
                                timer1.Stop();
                                mediaPlayer.URL = videoPath + "up.mov";
                                mediaPlayer.Ctlcontrols.play();
                                StartSlideshow("upFloor");
                            }

                        }
                    }

                    // If no floor matched, give an error response
                    if (!floorFound)
                    {
                        s = "Sorry, I couldn't find information on that floor.";
                        mediaPlayer.URL = videoPath + "sorryFloor.mov";
                        mediaPlayer.Ctlcontrols.play();
                    }
                }
                // Payment options command
                else if (recognizedText.Contains("payment options") || recognizedText.Contains("payment methods") || recognizedText.Contains("tuition payment") || recognizedText.Contains("pay tuition") || recognizedText.Contains("how can i pay my tuition") || recognizedText.Contains("how do i pay tuition") || recognizedText.Contains("how to pay tuition"))
                {
                    s = "Payment options include: Cash for onsite enrollment, credit card onsite, check (onsite and online), and bank transfer for online enrollment.";
                    mediaPlayer.URL = videoPath + "payment.mov";
                    mediaPlayer.Ctlcontrols.play();
                }

                // Organizations command
                else if (recognizedText.Contains("organizations") || recognizedText.Contains("clubs") || recognizedText.Contains("student groups"))
                {
                    s = "iACADEMY organizations include CSO, ISO, iACT, iACMedia, Vox Volare, iSekai, Momentum, Optics, Octave, Rhythm, and many more for both UG and SHS departments.";

                    mediaPlayer.URL = videoPath + "orgs.mov";
                    mediaPlayer.Ctlcontrols.play();
                }
                // Courses command
                else if (recognizedText.Contains("courses") || recognizedText.Contains("programs") || recognizedText.Contains("offered"))
                {
                    s = "Programs include Accountancy, Business, Arts and Design, Audio Production, Animation, Fashion, Graphic Illustration, Software Development, Robotics, Humanities, Game Development, Software Engineering, Data Science, Marketing, Psychology, and more.";

                    mediaPlayer.URL = videoPath + "courses.mov";
                    mediaPlayer.Ctlcontrols.play();
                }
                // Exit command
                else if (recognizedText.Contains("goodbye") || recognizedText.Contains("bye bot") || recognizedText.Contains("exit") || recognizedText.Contains("see you later"))
                {
                    s = "See you next time!";
                    mediaPlayer.URL = videoPath + "seeyou.mov";
                    mediaPlayer.Ctlcontrols.play();
                    System.Environment.Exit(0);
                    return;
                }
                else
                {
                    s = "I'm sorry, I didn't understand that command. Could you please repeat?";
                    mediaPlayer.URL = videoPath + "sorry.mov";
                    mediaPlayer.Ctlcontrols.play();
                }

                // Output the response and speak it
                txtSpeech.Text = s;
                //synth.Speak(s);
            }
        }


        private void btnEnable_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "MIC IS ENABLED";
            btnEnable.Enabled = false;
            btnEnable.BackColor = Color.Green;
            btnDisable.Enabled = true;
            btnDisable.BackColor = Color.Gray;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "MIC IS DISABLED";
            btnEnable.Enabled = true;
            btnEnable.BackColor = Color.Gray;
            btnDisable.Enabled = false;
            btnDisable.BackColor = Color.Red;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
