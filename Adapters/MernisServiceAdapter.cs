using GameDemo.Abstract;
using GameDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(player.NationalityId, player.FirstName, player.LastName, player.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }

    
}
