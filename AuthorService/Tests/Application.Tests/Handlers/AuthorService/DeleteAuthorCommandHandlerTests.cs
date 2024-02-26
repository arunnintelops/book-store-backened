﻿using Microsoft.Extensions.Logging;
using Moq;
using Application.Commands.AuthorService;
using Application.Exceptions;
using Application.Handlers.AuthorService;
using Core.Entities;
using Core.Repositories;

namespace Application.Tests.Handlers.AuthorService
{
    public class DeleteAuthorCommandHandlerTests
    {
        private readonly Mock<IAuthorRepository> _authorRepository;
        private readonly Mock<ILogger<DeleteAuthorCommandHandler>> _logger;

        public DeleteAuthorCommandHandlerTests()
        {
            _authorRepository = new();
            _logger = new();
        }

        [Fact]
        public async Task Handle_ThrowsAuthorNotFoundExceptionWhenAuthorNotFound()
        {
            // Arrange
            var Id = 123; // Replace with the ID you want to test
            var request = new DeleteAuthorCommand { Id = Id }; // Create a request object

            _authorRepository
                .Setup(r => r.GetByIdAsync(Id))
                .ReturnsAsync((Author)null); // Mock the repository to return null

            var handler = new DeleteAuthorCommandHandler(_authorRepository.Object, _logger.Object);

            // Act and Assert
            await Assert.ThrowsAsync<AuthorNotFoundException>(
                async () => await handler.Handle(request, CancellationToken.None)
            );
        }
    }
}
