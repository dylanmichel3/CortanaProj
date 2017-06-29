using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.VoiceCommands;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Background;
using Windows.ApplicationModel;
using System.Diagnostics;
using Windows.ApplicationModel.Resources.Core;
using Windows.Storage;
using Windows.System;

namespace TechtanaRT
{

    
    public sealed class TechtanaBackgroundTasks : IBackgroundTask
    {
        
        private BackgroundTaskDeferral defferal;
        private VoiceCommandServiceConnection voiceService;
       


        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            defferal = taskInstance.GetDeferral();
            var triggerDetails = taskInstance.TriggerDetails as AppServiceTriggerDetails;
            taskInstance.Canceled += OnCanceled;
            if (triggerDetails?.Name == "VoiceService")

            { 
            
               

                    voiceService = VoiceCommandServiceConnection.FromAppServiceTriggerDetails(triggerDetails);
                    voiceService.VoiceCommandCompleted += OnCompleted;
                    VoiceCommand voiceCommand = await voiceService.GetVoiceCommandAsync(); 


                    switch (voiceCommand.CommandName)

                    {
                     case "openMyTech":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;

                     case "openAccessories":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/accessoriesSpecialOrder.do");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                     case "isBrokenPhone":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/lifeEvents.do?sysparm=replaceBroken#/commsDevices");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                     case "isBrokenComputer":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/lifeEvents.do?sysparm=replaceBroken#/compDevices//");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                     case "missingComputer":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/lifeEvents.do?sysparm=lostStolen");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                     case "missingMobile":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/lifeEvents.do?sysparm=lostStolen#/commsDevices");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                    case "reassign":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/manage_request.do?sysparm=Reassign");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                    case "rAccessories":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/accessoriesSpecialOrder.do");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;

                     case "openMyTechnology":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/mytechnology.do");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "openMyTechGuide":
                            {

                                Uri website = new Uri(@"http://sc.ge.com/*mytechguide");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "openRequests":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/my_requests.do");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "openRefresh":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/lifeEvents.do?sysparm=refreshUpgrade");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "openRPhone":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/requestCommunication.do?sysparam=Phones");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "requestSoftware":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/software.do?sysparam=PC");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "manageSoftware":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/softwareLibrary.do");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;
                            
                     case "discoverMytech":
                            {

                                Uri website = new Uri(@"https://ge.service-now.com/mytech/discoverhome.do");
                                await Launcher.LaunchUriAsync(website);
                            };
                            break;

                     case "leaderCode":
                        {

                            Uri website = new Uri(@"https://ge.service-now.com/mytech/audioconferencing.do");
                            await Launcher.LaunchUriAsync(website);
                        };
                        break;


                }


                
                

            }
        }


        private void OnCompleted(VoiceCommandServiceConnection sender, VoiceCommandCompletedEventArgs args)
        {
            if (defferal != null)
            {
                defferal.Complete();
            }
        }

        private void OnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            if (defferal != null)
            {
                defferal.Complete(); 
            }
        }




    }
}
