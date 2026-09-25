
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nvm_Lesson10.Models;

public class NvmMembersController : Controller
{
    private readonly NvmK24cnt2Lesson10Context _context;

    public NvmMembersController(NvmK24cnt2Lesson10Context context)
    {
        _context = context;
    }

    // GET: NVMMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NvmMembers.ToListAsync());
    }

    // GET: NVMMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmmember = await _context.NvmMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvmmember == null)
        {
            return NotFound();
        }

        return View(nvmmember);
    }

    // GET: NVMMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NVMMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Username,Password")] NvmMember nvmmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nvmmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nvmmember);
    }

    // GET: NVMMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmmember = await _context.NvmMembers.FindAsync(id);
        if (nvmmember == null)
        {
            return NotFound();
        }
        return View(nvmmember);
    }

    // POST: NVMMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,Username,Password")] NvmMember nvmmember)
    {
        if (id != nvmmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nvmmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NvmMemberExists(nvmmember.Id))
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
        return View(nvmmember);
    }

    // GET: NVMMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmmember = await _context.NvmMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvmmember == null)
        {
            return NotFound();
        }

        return View(nvmmember);
    }

    // POST: NVMMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var nvmmember = await _context.NvmMembers.FindAsync(id);
        if (nvmmember != null)
        {
            _context.NvmMembers.Remove(nvmmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NvmMemberExists(long? id)
    {
        return _context.NvmMembers.Any(e => e.Id == id);
    }
}
