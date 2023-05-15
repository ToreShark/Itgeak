using Itgeak.BLL.Repositories;
using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;

namespace Itgeak.BLL;

public class UnitOfWork
{
    private readonly AppDbContext _db;
    
    public UnitOfWork(AppDbContext db)
    {
        _db = db;
    }
    
    private AuthRepository _authRepository;
    private PostRepository _postRepository;
    private CommentRepository _commentRepository;
    private RoleRepository _roleRepository;
    private UserRepository _userRepository;
    private TagRepository _tagRepository;
    private CategoryRepository _categoryRepository;

    public AuthRepository AuthRepository
    {
        get
        {
            if (_authRepository == null)
            {
                _authRepository = new AuthRepository(_db);
            }
            return _authRepository;
        }
    }
    public PostRepository PostRepository
    {
        get
        {
            if (_postRepository == null)
            {
                _postRepository = new PostRepository(_db);
            }
            return _postRepository;
        }
    }
    public CommentRepository CommentRepository
    {
        get
        {
            if (_commentRepository == null)
            {
                _commentRepository = new CommentRepository(_db);
            }
            return _commentRepository;
        }
    }
    public RoleRepository RoleRepository
    {
        get
        {
            if (_roleRepository == null)
            {
                _roleRepository = new RoleRepository(_db);
            }
            return _roleRepository;
        }
    }
    public UserRepository UserRepository
    {
        get
        {
            if (_userRepository == null)
            {
                _userRepository = new UserRepository(_db);
            }
            return _userRepository;
        }
    }
    public TagRepository TagRepository
    {
        get
        {
            if (_tagRepository == null)
            {
                _tagRepository = new TagRepository(_db);
            }
            return _tagRepository;
        }
    }
    public CategoryRepository CategoryRepository
    {
        get
        {
            if (_categoryRepository == null)
            {
                _categoryRepository = new CategoryRepository(_db);
            }
            return _categoryRepository;
        }
    }
}