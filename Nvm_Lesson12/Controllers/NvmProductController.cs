
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nvm_Lesson12.Models;
using Nvm_Lesson12.Entities;

public class NvmProductController : Controller
{
    private readonly AddDbContext _context;

    public NvmProductController(AddDbContext context)
    {
        _context = context;
    }

    // GET: NVMPRODUCTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Products.ToListAsync());
    }

    // GET: NVMPRODUCTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmproduct = await _context.Products
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvmproduct == null)
        {
            return NotFound();
        }

        return View(nvmproduct);
    }

    // GET: NVMPRODUCTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NVMPRODUCTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Image,Price,Saleprice,Status,Descriptions,CategoryId,CategoryDate,Category")] NvmProduct nvmproduct)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nvmproduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nvmproduct);
    }

    // GET: NVMPRODUCTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmproduct = await _context.Products.FindAsync(id);
        if (nvmproduct == null)
        {
            return NotFound();
        }
        return View(nvmproduct);
    }

    // POST: NVMPRODUCTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Image,Price,Saleprice,Status,Descriptions,CategoryId,CategoryDate,Category")] NvmProduct nvmproduct)
    {
        if (id != nvmproduct.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nvmproduct);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NvmProductExists(nvmproduct.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(nvmproduct);
    }

    // GET: NVMPRODUCTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmproduct = await _context.Products
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvmproduct == null)
        {
            return NotFound();
        }

        return View(nvmproduct);
    }

    // POST: NVMPRODUCTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nvmproduct = await _context.Products.FindAsync(id);
        if (nvmproduct != null)
        {
            _context.Products.Remove(nvmproduct);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NvmProductExists(int? id)
    {
        return _context.Products.Any(e => e.Id == id);
    }
}
