using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Followers
{
    public class FollowToggle
    {

        // public class Command : IRequest<Result<Unit>>
        // {
        //     public string TargetUsername { get; set; }  

        // }

        // public class Handler : IRequestHandler<Command, Result<Unit>>
        // {
        //     private readonly DataContext _context;
        //     private readonly IUserAccessor _userAccessor;
        //     public Handler(DataContext context, IUserAccessor userAccessor)
        //     {
        //         _userAccessor = userAccessor;
        //         _context = context;                
        //     }
            

            // public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            // {
            //     var observer = await  _context.Users.FirstOrDefaultAsync(x => x.UserName);
            // }
        }
    }
