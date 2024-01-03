using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobApply_DF.Controllers
{
    public class AdminController : ApiController
    {
            // Route 1

            [Route("api/login/users")]
            [HttpGet]
            public HttpResponseMessage GetLogusers()
            {
                var data = LoginService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            // Route 2
            [Route("api/login/delete/{id}")]
            [HttpGet]
            public HttpResponseMessage DeleteLogUser(int id)
            {
                var data = LoginService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }


            // Route 3
            [Route("api/login/user/{id}")]
            [HttpGet]
            public HttpResponseMessage GetLogUser(int id)
            {
                var data = LoginService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }


            // Route 4
            [Route("api/users")]
            [HttpGet]
            public HttpResponseMessage Get()
            {
                var data = UserDetailService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }


            // Route 5
            [Route("api/user/active/{id}")]
            [HttpPost]
            public HttpResponseMessage ActivateUser(int id)
            {
                var user = UserDetailService.Get(id);

                var resp = UserDetailService.ChangeStatus(user, "1");
                if (resp != false)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Activated", data = resp });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);

            }



            // Route 6
            [Route("api/user/block/{id}")]
            [HttpPost]
            public HttpResponseMessage BlockUser(int id)
            {
                var user = UserDetailService.Get(id);
                var resp = UserDetailService.ChangeStatus(user, "2");
                if (resp != false)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Blocked", data = resp });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);

            }

        // Route 7

        [Route("api/user/academicinfo/add")]
        [HttpPost]
        public HttpResponseMessage Post(AcademicInfoDTO dto)
        {

            var resp = AcademicInfoService.Add(dto);
            if (resp != false)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Registered", data = resp });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);

        }

        // Route 8

        [Route("api/user/academicinfo/update")]
        [HttpPost]
        public HttpResponseMessage Updateacademic(AcademicInfoDTO dto)
        {

            var resp = AcademicInfoService.Update(dto);
            if (resp != false)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Registered", data = resp });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);

        }


        // Route 9

        [Route("api/user/academicinfo/{id}")]
        [HttpGet]
        public HttpResponseMessage Viewacademic(int id)
        {

            var data = AcademicInfoService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
