import React from "react";

const Navbar = ({ data }) => {
  return (
    <div
      className="flex flex-row justify-start shadow-md  text-yellow-300 p-4 w-full"
      style={{ background: "#333" }}
    >
      <div className="text-3xl font-bold text-yellow">
        Group Members
      </div>

      <div className="flex flex-row justify-end flex-grow">
        <p className="text-2xl">Content</p>
        <div className="underline-none p-2 border-r"></div>
        {data.map((el) => (
          <a
            className="underline-none p-2 border-r text-lg hover:font-bold"
            href={`#${el.name}`}
            key={el.name}
          >
            {el.name}
          </a>
        ))}
      </div>
    </div>
  );
};

export default Navbar;