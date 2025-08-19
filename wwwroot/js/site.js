document.addEventListener("click", (e) => {
  const t = e.target.closest(".accordion-toggle");
  if (!t) return;
  const target = document.querySelector(t.dataset.target);
  if (!target) return;
  const open = target.style.display === "block";
  document.querySelectorAll(".accordion-content").forEach(el => el.style.display="none");
  target.style.display = open ? "none" : "block";
});

// Sticky call button (mobile)
(function(){
  const btn = document.createElement('a');
  btn.href = 'tel:+905325436837';
  btn.className = 'btn sticky-call';
  btn.textContent = 'Hemen Ara';
  Object.assign(btn.style, { position:'fixed', right:'16px', bottom:'16px', zIndex:9999, padding:'12px 14px', borderRadius:'12px', textDecoration:'none', background:'#DA1526', color:'#fff', fontWeight:'800', boxShadow:'0 6px 18px rgba(0,0,0,.2)'});
  document.addEventListener('DOMContentLoaded', ()=>{
    document.body.appendChild(btn);
  });
})();