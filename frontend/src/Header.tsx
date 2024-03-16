// Header of the page
function Header() {
  return (
    <>
      <nav className="navbar bg-body-tertiary">
        <h2 className="navbar-brand mx-3">Bowling League Database</h2>
      </nav>
      <br />
      <p className="conatiner">
        This is a database of all the bowlers in the Bowlers database. However,
        it's filtered down to only show the Marlins and Sharks teams.
      </p>
    </>
  );
}

export default Header;
