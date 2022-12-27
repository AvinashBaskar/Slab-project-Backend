using Microsoft.AspNetCore.Mvc;
using Backendslap.Models;

namespace Backendslap.Controllers;

[ApiController]
[Route("api/slap")]

public class SlapController : ControllerBase
{

    //Entities object
    public readonly SlapContext SlapDB;

    public SlapController(SlapContext Slapdb)
    {
        this.SlapDB=Slapdb;
    }

    //Display all Drivers  from db
    [HttpGet("GetAllSlap")]

    public IQueryable<Slaptable> GetAllSlap()
    {
        try{
            return SlapDB.Slaptables;
        }
        catch(System.Exception)
        {
            throw;
        }
        
    }

    [HttpGet("GetDefSlap")]

    public IQueryable<SlapDefinition> GetDefSlap()
    {
        try{
            return SlapDB.SlapDefinitions;
        }
        catch(System.Exception)
        {
            throw;
        }
        
    }

    [HttpPost("InsertSlap")]

    public object InsertSlap(RegSlap slapobj)
    {
        try{
            Slaptable dl = new Slaptable();
            if(dl.Slapid==0)
            {
                // dl.Slapid=slapobj.RegSlapid;
                dl.SlapName=slapobj.RegSlapName;
                dl.PayGroupCode=slapobj.RegPayGroupCode;
                dl.SlapLowValue=slapobj.RegSlapLowValue;
                dl.SlapHighValue=slapobj.RegSlapHighValue;
                dl.SlapPercentage=slapobj.RegSlapPercentage;
                dl.SlapValue=slapobj.RegSlapValue;
            

            SlapDB.Slaptables.Add(dl);

            SlapDB.SaveChanges();
        
        return new Response{Status="Success", Message="Slap Added!"};
            }
        }
        catch(System.Exception)
        {
            throw;
        }
        return new Response{Status="Error", Message="Slap not added"};
    }


[HttpPost("InsertSlapDefinition")]

    public object InsertSlapDefinition(SlapReg obj)
    {
        try{
            SlapDefinition el = new SlapDefinition();
            if(el.Slid==0)
            {
                // dl.Slapid=slapobj.RegSlapid;
                el.ShortName=obj.RegShortName;
                el.PayGroupCode=obj.RegPayGroupCode;
                el.DescriptionS=obj.RegDescriptionS;
                el.StatusS=obj.RegStatusS;
                
            

            SlapDB.SlapDefinitions.Add(el);

            SlapDB.SaveChanges();
        
        return new Response{Status="Success", Message="Slap Added!"};
            }
        }
        catch(System.Exception)
        {
            throw;
        }
        return new Response{Status="Error", Message="Slap not added"};
    }

}