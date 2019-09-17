instance.SetContentPolicy(
	"DirectLoad", // режимы: "DirectLoad", "WhiteList", "BlockList".
	domains: null, // или по аналогии с regexs
	regexs: new[]
	{
		"ya.ru",
		"google.com"
	}
);