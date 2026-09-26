
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenVanMy2410900054_exam.Models;

public class NvmStudentController : Controller
{
    private readonly Nvm2410900054DbContext _context;

    public NvmStudentController(Nvm2410900054DbContext context)
    {
        _context = context;
    }

    // GET: NVMSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NvmStudents.ToListAsync());
    }

    // GET: NVMSTUDENTS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmstudent = await _context.NvmStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvmstudent == null)
        {
            return NotFound();
        }

        return View(nvmstudent);
    }

    // GET: NVMSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NVMSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NvmName,NvmGender,NvmBirthday,NvmEmail,NvmPhone,NvmActive")] NvmStudent nvmstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nvmstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nvmstudent);
    }

    // GET: NVMSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmstudent = await _context.NvmStudents.FindAsync(id);
        if (nvmstudent == null)
        {
            return NotFound();
        }
        return View(nvmstudent);
    }

    // POST: NVMSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,NvmName,NvmGender,NvmBirthday,NvmEmail,NvmPhone,NvmActive")] NvmStudent nvmstudent)
    {
        if (id != nvmstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nvmstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NvmStudentExists(nvmstudent.Id))
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
        return View(nvmstudent);
    }

    // GET: NVMSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvmstudent = await _context.NvmStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvmstudent == null)
        {
            return NotFound();
        }

        return View(nvmstudent);
    }

    // POST: NVMSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var nvmstudent = await _context.NvmStudents.FindAsync(id);
        if (nvmstudent != null)
        {
            _context.NvmStudents.Remove(nvmstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NvmStudentExists(long? id)
    {
        return _context.NvmStudents.Any(e => e.Id == id);
    }
}
