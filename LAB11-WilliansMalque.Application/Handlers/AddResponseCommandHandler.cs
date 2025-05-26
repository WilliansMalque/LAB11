using LAB11_WilliansMalque.Application.Commands;
using MediatR;
using AutoMapper;
using System;
using System.Threading;
using System.Threading.Tasks;
using LAB11_WilliansMalque.Infrastructure.Models;

namespace LAB11_WilliansMalque.Application.Handlers
{
    internal sealed class AddResponseCommandHandler : IRequestHandler<AddResponseCommand, Guid>
    {
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddResponseCommandHandler(IUnitOfWork.IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(AddResponseCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<response>(request);

            entity.response_id = Guid.NewGuid();
            entity.created_at = DateTime.UtcNow;

            _unitOfWork.ResponseRepository.Add(entity);
            await _unitOfWork.CompleteAsync();

            return entity.response_id;
        }
    }
}