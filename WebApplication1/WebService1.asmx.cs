using ImperialVolumeToMetric1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public float fluidToOunce(float fo)
        {
            return ImperialVolumeToMetric.flOz(fo);
        }

        [WebMethod]
        public float gillToMill (float gm)
        {
            return ImperialVolumeToMetric.gillToMl(gm);
        }

        [WebMethod]
        public float cupToMill(float cm)
        {
            return ImperialVolumeToMetric.cupToMl(cm);
        }

        [WebMethod]
        public float pintToGill(float pg)
        {
            return ImperialVolumeToMetric.pintToGill(pg);
        }

        [WebMethod]
        public float pintToFluidOunce(float pfo)
        {
            return ImperialVolumeToMetric.pintToFlOz(pfo);
        }

        [WebMethod]
        public float quartToMill(float qm)
        {
            return ImperialVolumeToMetric.quartToMl(qm);
        }
        [WebMethod]
        public float gallToQuart(float gq)
        {
            return ImperialVolumeToMetric.gallonToQuart(gq);
        }
        [WebMethod]
        public float gallToPint(float gp)
        {
            return ImperialVolumeToMetric.gallonToPint(gp);
        }
        [WebMethod]
        public float BarToLitres(float bl)
        {
            return ImperialVolumeToMetric.barrelToLitres(bl);
        }
    }
}
