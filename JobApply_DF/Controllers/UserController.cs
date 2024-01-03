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
    public class UserController : ApiController
    {
        // Route 1
        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserDetailService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        // Route 2
        [Route("api/users/add")]
        [HttpPost]
        public HttpResponseMessage Post(UsersDetailDTO u)
        {
            if (ModelState.IsValid)
            {
                var r = Request.Headers.Authorization;
                string token = r.ToString();
                var data = AuthService.GetCurrentUserLog(token);
                var resp = UserDetailService.Add(u, data.Id);

                if (resp != false)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Inserted", data = resp });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }

        }


        // Route 3

        [Route("api/users/update")]
        [HttpPost]
        public HttpResponseMessage Update(UsersDetailDTO user)
        {
            if (ModelState.IsValid)
            {
                var resp = UserDetailService.Update(user);
                if (resp != false)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Inserted", data = resp });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }

        }

        // Route 4
        [Route("api/user/academicinfo")]
        [HttpGet]
        public HttpResponseMessage Viewacademic()
        {
            var r = Request.Headers.Authorization;
            string token = r.ToString();
            var user = AuthService.GetCurrentUser(token);


            var data = AcademicInfoService.Get(user.Nid);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        // Route 5
        // - Apply Job
        [Route("api/application/apply/{id}")]
        [HttpGet]
        public HttpResponseMessage JobApply(int id)
        {
            var r = Request.Headers.Authorization;
            string token = r.ToString();
            var user = AuthService.GetCurrentUser(token);

            var ExistsApp = ApplyService.IsExistsApplication(id, user.Nid);

            if (ExistsApp != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Application Exists Already" });
            }
            else
            {
                bool res = ApplyService.Add(user.Nid, id);

                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Application submitted" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }

            }
        }

    }
}
